using GigHub.Data;
using GigHub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {

            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}
