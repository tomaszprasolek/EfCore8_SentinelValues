using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore8_SentinelValues.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 5, 45, 24, 988, DateTimeKind.Utc).AddTicks(8016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 5, 43, 8, 338, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 5, 43, 8, 338, DateTimeKind.Utc).AddTicks(8548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 5, 45, 24, 988, DateTimeKind.Utc).AddTicks(8016));
        }
    }
}
