﻿using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEFCore.DTOs
{
    public class ActorCreacionDTO
    {
        [StringLength(150)]
        public string Nombre { get; set; } = null!;
        public decimal Forturna { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
