namespace GestionLaboratoire.Models
{
    public class Echantillon
    {
        public int EchantillonID { get; set; }
        public int PatientID { get; set; }
        public int AnalyseID { get; set; }
        public double Resultat { get; set; }
        public string Statut { get; set; } // Prélevé, En cours, Traité
        public Patient Patient { get; set; }
        public Analyses Analyse { get; set; }
    }
}
