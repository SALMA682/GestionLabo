using GestionLaboratoire.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace GestionLaboratoire.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Analyses> Analyses { get; set; }
        public DbSet<Echantillon> Echantillons { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analyses>().HasKey(a => a.AnalyseID);
            modelBuilder.Entity<Analyses>().HasData(
                new Analyses { AnalyseID = 1, Nom = "Glycémie à jeun", Prix = 33, ValeurMin=0.70, ValeurMax=1.10 },
                new Analyses { AnalyseID = 2, Nom = "Créatinine Sérique", Prix = 33, ValeurMin = 5, ValeurMax = 11 },
                new Analyses { AnalyseID = 3, Nom = "Hémoglobine", Prix = 33, ValeurMin = 12.5, ValeurMax = 15 },
                new Analyses { AnalyseID = 4, Nom = "Cholestérol total", Prix = 60, ValeurMin = 1, ValeurMax = 2 },
                new Analyses { AnalyseID= 5, Nom = "Bilirubine totale", Prix = 33, ValeurMin = 0.2, ValeurMax = 1.2 },
                new Analyses { AnalyseID= 6, Nom = "Vitesse de sedimentation", Prix=40, ValeurMin = 0, ValeurMax = 17 }
             );
            modelBuilder.Entity<Utilisateur>().HasData(
<<<<<<< HEAD
                new Utilisateur { UtilisateurID = 1, Nom = "Salma", Email = "ighirouaioursalma@gmail.com", MotDePasse = "1234", Role = "Administrateur" },
                 new Utilisateur { UtilisateurID = 2, Nom = "Chaimaa", Email = "Chaimaa@gmail.com", MotDePasse = "5678", Role = "Assistant" },
                  new Utilisateur { UtilisateurID = 3, Nom = "Salah", Email = "Salah@gmail.com", MotDePasse = "9012", Role = "Preleveur" });
            modelBuilder.Entity<Patient>().HasData(
               new Patient{ PatientID = 1, Nom = "kamal", Prenom="ka", CIN="aze123", Contact="0657849678", Email = "kamal@gmail.com", MedecinTraitant="hicham" },
                new Patient { PatientID = 2, Nom = "houda", Prenom = "ho", CIN = "rty456", Contact = "0612568340", Email = "houda@gmail.com", MedecinTraitant = "hicham" },
                 new Patient { PatientID = 3, Nom = "salim", Prenom = "sa", CIN = "uio890", Contact = "0657459836", Email = "salim@gmail.com", MedecinTraitant = "hicham" });
        
     }
       
=======
                new Utilisateur { UtilisateurID = 1, Nom = "Salma", Email = "ighirouaioursalma@gmail.com", MotDePasse = "1234", Role = "Administrateur" });
        }
>>>>>>> 025a393c2808b2686799f8acb89069623e8c7b70
    }
}
