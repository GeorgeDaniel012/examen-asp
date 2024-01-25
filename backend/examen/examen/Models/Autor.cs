namespace examen.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public Editura Editura { get; set; }
        public int EdituraId { get; set; }
        public ICollection<AutorCarte>? AutoriCarti {  get; set; }
    }
}
