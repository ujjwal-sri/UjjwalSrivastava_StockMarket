using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AdminAPI.Migrations
{
    public partial class Three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPrices_Company_CompanyCode",
                table: "StockPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockPrices",
                table: "StockPrices");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "StockPrices",
                newName: "StockPrice");

            migrationBuilder.RenameIndex(
                name: "IX_StockPrices_CompanyCode",
                table: "StockPrice",
                newName: "IX_StockPrice_CompanyCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockPrice",
                table: "StockPrice",
                column: "RowId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrice_Company_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode",
                principalTable: "Company",
                principalColumn: "CompanyCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPrice_Company_CompanyCode",
                table: "StockPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockPrice",
                table: "StockPrice");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "StockPrice",
                newName: "StockPrices");

            migrationBuilder.RenameIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrices",
                newName: "IX_StockPrices_CompanyCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockPrices",
                table: "StockPrices",
                column: "RowId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrices_Company_CompanyCode",
                table: "StockPrices",
                column: "CompanyCode",
                principalTable: "Company",
                principalColumn: "CompanyCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
