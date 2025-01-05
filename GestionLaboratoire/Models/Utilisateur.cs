namespace GestionLaboratoire.Models
{
    public class Utilisateur
    {
        public int UtilisateurID { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
    }
}
