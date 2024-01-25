namespace examen.Models
{
    public class AutorCarte
    {
        //public int Id { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int CarteId { get; set; }
        public Carte Carte { get; set; }
    }
}
