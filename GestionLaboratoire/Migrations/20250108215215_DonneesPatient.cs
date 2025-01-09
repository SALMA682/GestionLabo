using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionLaboratoire.Migrations
{
    /// <inheritdoc />
    public partial class DonneesPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "CIN", "Contact", "Email", "MedecinTraitant", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "aze123", "0657849678", "kamal@gmail.com", "hicham", "kamal", "ka" },
                    { 2, "rty456", "0612568340", "houda@gmail.com", "hicham", "houda", "ho" },
                    { 3, "uio890", "0657459836", "salim@gmail.com", "hicham", "salim", "sa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 3);
        }
    }
}
