namespace IntroduccionAEFCore.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Forturna { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<PeliculaActor> PeliculaActores { get; set; } = new List<PeliculaActor>();
    }
}
