using Microsoft.EntityFrameworkCore.Migrations;

namespace Second_Project.Migrations
{
    public partial class ProcFin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string Procedure = @"Create procedure FinProc as Begin Select * From AspNetUsers End";
            migrationBuilder.Sql(Procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string Procedure = @"Create procedure FinProc";
            migrationBuilder.Sql(Procedure);
        }
    }
}
