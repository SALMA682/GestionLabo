using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionLaboratoire.Migrations
{
    /// <inheritdoc />
    public partial class AjoutUtilisateurs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utilisateurs",
                columns: new[] { "UtilisateurID", "Email", "MotDePasse", "Nom", "Role" },
                values: new object[,]
                {
                    { 2, "Chaimaa@gmail.com", "5678", "Chaimaa", "Assistant" },
                    { 3, "Salah@gmail.com", "9012", "Salah", "Preleveur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateurs",
                keyColumn: "UtilisateurID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilisateurs",
                keyColumn: "UtilisateurID",
                keyValue: 3);
        }
    }
}
