﻿// <auto-generated />
using GestionLaboratoire.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionLaboratoire.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionLaboratoire.Models.Analyses", b =>
                {
                    b.Property<int>("AnalyseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnalyseID"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("ValeurMax")
                        .HasColumnType("float");

                    b.Property<double>("ValeurMin")
                        .HasColumnType("float");

                    b.HasKey("AnalyseID");

                    b.ToTable("Analyses");

                    b.HasData(
                        new
                        {
                            AnalyseID = 1,
                            Nom = "Glycémie à jeun",
                            Prix = 33m,
                            ValeurMax = 1.1000000000000001,
                            ValeurMin = 0.69999999999999996
                        },
                        new
                        {
                            AnalyseID = 2,
                            Nom = "Créatinine Sérique",
                            Prix = 33m,
                            ValeurMax = 11.0,
                            ValeurMin = 5.0
                        },
                        new
                        {
                            AnalyseID = 3,
                            Nom = "Hémoglobine",
                            Prix = 33m,
                            ValeurMax = 15.0,
                            ValeurMin = 12.5
                        },
                        new
                        {
                            AnalyseID = 4,
                            Nom = "Cholestérol total",
                            Prix = 60m,
                            ValeurMax = 2.0,
                            ValeurMin = 1.0
                        },
                        new
                        {
                            AnalyseID = 5,
                            Nom = "Bilirubine totale",
                            Prix = 33m,
                            ValeurMax = 1.2,
                            ValeurMin = 0.20000000000000001
                        },
                        new
                        {
                            AnalyseID = 6,
                            Nom = "Vitesse de sedimentation",
                            Prix = 40m,
                            ValeurMax = 17.0,
                            ValeurMin = 0.0
                        });
                });

            modelBuilder.Entity("GestionLaboratoire.Models.Echantillon", b =>
                {
                    b.Property<int>("EchantillonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EchantillonID"));

                    b.Property<int>("AnalyseID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<double>("Resultat")
                        .HasColumnType("float");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EchantillonID");

                    b.HasIndex("AnalyseID");

                    b.HasIndex("PatientID");

                    b.ToTable("Echantillons");
                });

            modelBuilder.Entity("GestionLaboratoire.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"));

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedecinTraitant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientID = 1,
                            CIN = "aze123",
                            Contact = "0657849678",
                            Email = "kamal@gmail.com",
                            MedecinTraitant = "hicham",
                            Nom = "kamal",
                            Prenom = "ka"
                        },
                        new
                        {
                            PatientID = 2,
                            CIN = "rty456",
                            Contact = "0612568340",
                            Email = "houda@gmail.com",
                            MedecinTraitant = "hicham",
                            Nom = "houda",
                            Prenom = "ho"
                        },
                        new
                        {
                            PatientID = 3,
                            CIN = "uio890",
                            Contact = "0657459836",
                            Email = "salim@gmail.com",
                            MedecinTraitant = "hicham",
                            Nom = "salim",
                            Prenom = "sa"
                        });
                });

            modelBuilder.Entity("GestionLaboratoire.Models.Utilisateur", b =>
                {
                    b.Property<int>("UtilisateurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtilisateurID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilisateurID");

                    b.ToTable("Utilisateurs");

                    b.HasData(
                        new
                        {
                            UtilisateurID = 1,
                            Email = "ighirouaioursalma@gmail.com",
                            MotDePasse = "1234",
                            Nom = "Salma",
                            Role = "Administrateur"
                        },
                        new
                        {
                            UtilisateurID = 2,
                            Email = "Chaimaa@gmail.com",
                            MotDePasse = "5678",
                            Nom = "Chaimaa",
                            Role = "Assistant"
                        },
                        new
                        {
                            UtilisateurID = 3,
                            Email = "Salah@gmail.com",
                            MotDePasse = "9012",
                            Nom = "Salah",
                            Role = "Preleveur"
                        });
                });

            modelBuilder.Entity("GestionLaboratoire.Models.Echantillon", b =>
                {
                    b.HasOne("GestionLaboratoire.Models.Analyses", "Analyse")
                        .WithMany()
                        .HasForeignKey("AnalyseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionLaboratoire.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Analyse");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
