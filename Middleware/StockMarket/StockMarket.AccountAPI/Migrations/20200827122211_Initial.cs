﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AccountAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(maxLength: 30, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 25, nullable: false),
                    TurnOver = table.Column<int>(nullable: false),
                    CEO = table.Column<string>(maxLength: 30, nullable: true),
                    BoardOfDirectors = table.Column<string>(nullable: true),
                    ListInStockExchanges = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    CompanyWriteup = table.Column<string>(nullable: true),
                    StockCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyCode);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 30, nullable: false),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    UserType = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Mobile = table.Column<string>(maxLength: 13, nullable: true),
                    Confirmed = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    RowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(maxLength: 30, nullable: true),
                    StockExchange = table.Column<string>(maxLength: 30, nullable: false),
                    CurrentPrice = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_StockPrice_Company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "Company",
                        principalColumn: "CompanyCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
