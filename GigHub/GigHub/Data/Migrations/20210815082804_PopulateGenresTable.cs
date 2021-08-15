namespace GigHub.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    public partial class PopulateGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Rock')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Pop')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Blues')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Classic')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM GENRES WHERE Id IN (1,2,3,4,5)");

        }
    }
}
