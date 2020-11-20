using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseConnection.Migrations
{
    public partial class fixedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomersCustomerId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Movies_MoviesMovieId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "MoviesMovieId",
                table: "Rentals",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "CustomersCustomerId",
                table: "Rentals",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_MoviesMovieId",
                table: "Rentals",
                newName: "IX_Rentals_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_CustomersCustomerId",
                table: "Rentals",
                newName: "IX_Rentals_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Movies_MovieId",
                table: "Rentals",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Movies_MovieId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Rentals",
                newName: "MoviesMovieId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Rentals",
                newName: "CustomersCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_MovieId",
                table: "Rentals",
                newName: "IX_Rentals_MoviesMovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                newName: "IX_Rentals_CustomersCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomersCustomerId",
                table: "Rentals",
                column: "CustomersCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Movies_MoviesMovieId",
                table: "Rentals",
                column: "MoviesMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
