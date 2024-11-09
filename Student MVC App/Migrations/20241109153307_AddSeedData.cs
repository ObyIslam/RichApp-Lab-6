using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_MVC_App.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_Emailaddress",
                table: "Students",
                column: "Emailaddress",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_Emailaddress",
                table: "Students");
        }
    }
}
