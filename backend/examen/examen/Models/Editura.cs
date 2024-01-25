namespace examen.Models
{
    public class Editura
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public ICollection<Autor>? Autori { get; set; }
    }
}
