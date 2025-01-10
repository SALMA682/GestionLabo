using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionLaboratoire.Migrations
{
    /// <inheritdoc />
    public partial class MiseAJour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analyses",
                columns: table => new
                {
                    AnalyseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ValeurMin = table.Column<double>(type: "float", nullable: false),
                    ValeurMax = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.AnalyseID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedecinTraitant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurID);
                });

            migrationBuilder.CreateTable(
                name: "Echantillons",
                columns: table => new
                {
                    EchantillonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    AnalyseID = table.Column<int>(type: "int", nullable: false),
                    Resultat = table.Column<double>(type: "float", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Echantillons", x => x.EchantillonID);
                    table.ForeignKey(
                        name: "FK_Echantillons_Analyses_AnalyseID",
                        column: x => x.AnalyseID,
                        principalTable: "Analyses",
                        principalColumn: "AnalyseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Echantillons_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Analyses",
                columns: new[] { "AnalyseID", "Nom", "Prix", "ValeurMax", "ValeurMin" },
                values: new object[,]
                {
                    { 1, "Glycémie à jeun", 33m, 1.1000000000000001, 0.69999999999999996 },
                    { 2, "Créatinine Sérique", 33m, 11.0, 5.0 },
                    { 3, "Hémoglobine", 33m, 15.0, 12.5 },
                    { 4, "Cholestérol total", 60m, 2.0, 1.0 },
                    { 5, "Bilirubine totale", 33m, 1.2, 0.20000000000000001 },
                    { 6, "Vitesse de sedimentation", 40m, 17.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "CIN", "Contact", "Email", "MedecinTraitant", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "aze123", "0657849678", "kamal@gmail.com", "hicham", "kamal", "ka" },
                    { 2, "rty456", "0612568340", "houda@gmail.com", "hicham", "houda", "ho" },
                    { 3, "uio890", "0657459836", "salim@gmail.com", "hicham", "salim", "sa" }
                });

            migrationBuilder.InsertData(
                table: "Utilisateurs",
                columns: new[] { "UtilisateurID", "Email", "MotDePasse", "Nom", "Role" },
                values: new object[,]
                {
                    { 1, "ighirouaioursalma@gmail.com", "1234", "Salma", "Administrateur" },
                    { 2, "Chaimaa@gmail.com", "5678", "Chaimaa", "Assistant" },
                    { 3, "Salah@gmail.com", "9012", "Salah", "Preleveur" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Echantillons_AnalyseID",
                table: "Echantillons",
                column: "AnalyseID");

            migrationBuilder.CreateIndex(
                name: "IX_Echantillons_PatientID",
                table: "Echantillons",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Echantillons");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Analyses");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
