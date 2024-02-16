using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WashingLaundary.Migrations
{
    /// <inheritdoc />
    public partial class FirstV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Customers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Clothes",
                newName: "IsActive");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Customers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Customers",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Clothes",
                newName: "IsDeleted");
        }
    }
}
