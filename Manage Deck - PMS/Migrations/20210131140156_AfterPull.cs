using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manage_Deck___PMS.Migrations
{
    public partial class AfterPull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "Checklist",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Priority = table.Column<int>(nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => x.Id);
                });

        }

          


               

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropTable(
                name: "Checklist");

        }
    }
}
