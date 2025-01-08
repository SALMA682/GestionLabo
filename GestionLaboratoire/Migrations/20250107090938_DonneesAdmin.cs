using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionLaboratoire.Migrations
{
    /// <inheritdoc />
    public partial class DonneesAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utilisateurs",
                columns: new[] { "UtilisateurID", "Email", "MotDePasse", "Nom", "Role" },
                values: new object[] { 1, "ighirouaioursalma@gmail.com", "1234", "Salma", "Administrateur" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateurs",
                keyColumn: "UtilisateurID",
                keyValue: 1);
        }
    }
}
