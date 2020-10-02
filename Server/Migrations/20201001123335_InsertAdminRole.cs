using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class InsertAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string insertSql = "INSERT INTO AspNetRoles (Id, [Name], NormalizedName) VALUES ('b3cb30a9-2d9f-4f3f-9971-b44bbebd2c6d', 'Admin', 'Admin')";
            migrationBuilder.Sql(insertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string deleteSql = "DELETE FROM AspNetRoles WHERE Id = 'b3cb30a9-2d9f-4f3f-9971-b44bbebd2c6d'";
            migrationBuilder.Sql(deleteSql);
        }
    }
}
