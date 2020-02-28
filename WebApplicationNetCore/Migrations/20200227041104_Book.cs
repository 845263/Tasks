using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationNetCore.Migrations
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Btitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Authorname = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Bid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
