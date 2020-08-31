using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AdminAPI.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IPOs",
                table: "IPOs");

            migrationBuilder.RenameTable(
                name: "IPOs",
                newName: "IPO");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCode",
                table: "IPO",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IPO",
                table: "IPO",
                column: "IPOID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IPO",
                table: "IPO");

            migrationBuilder.DropColumn(
                name: "CompanyCode",
                table: "IPO");

            migrationBuilder.RenameTable(
                name: "IPO",
                newName: "IPOs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IPOs",
                table: "IPOs",
                column: "IPOID");
        }
    }
}
