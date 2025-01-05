using System.ComponentModel.DataAnnotations;

namespace GestionLaboratoire.Models
{
    public class Analyses
    {
        public int AnalyseID { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public decimal Prix { get; set; }
        [Required]
        public double ValeurMin { get; set; }
        [Required]
        public double ValeurMax { get; set; }
    }
}
