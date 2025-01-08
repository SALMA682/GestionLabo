namespace GestionLaboratoire.Models
{
    public class Patient
    {


        public int PatientID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string MedecinTraitant { get; set; }

    }
}
