using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminOrders.Migrations
{
    /// <inheritdoc />
    public partial class ProMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "MRP",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "PharmacyName",
                table: "ProductDetails",
                newName: "ProductName");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductImageUrl",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductInStock",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductImageUrl",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductInStock",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "ProductDetails",
                newName: "PharmacyName");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "ProductDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "MRP",
                table: "ProductDetails",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
