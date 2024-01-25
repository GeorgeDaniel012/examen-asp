namespace examen.Models
{
    public class Carte
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public ICollection<AutorCarte> AutoriCarti { get; set; }
    }
}
