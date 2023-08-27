using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroFutbol.Models
{
    public class Jugador
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Genero { get; set; }
        public string? Club { get; set; }
        public List<string> Categoria { get; set; } = new List<string>();
        public int Temporada { get; set; }
        public decimal MontoTotal { get; set; }

        public bool Faltas { get; set; }
    }
}