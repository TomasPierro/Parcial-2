using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesP.Models
{
    public class Artista
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public List<Cancion> Canciones = new List<Cancion>();
    }
}
