namespace IntroduccionAEFCore.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }
        public HashSet<Comentarios> Comentarios { get; set; } = new HashSet<Comentarios>();
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
    }
}
