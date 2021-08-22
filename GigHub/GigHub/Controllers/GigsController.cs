using GigHub.Data;
using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {

            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(GigFormViewModel viewModel)
        {
            var artistId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gig = new Gig
            {
                ArtistId = artistId,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue

            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}

