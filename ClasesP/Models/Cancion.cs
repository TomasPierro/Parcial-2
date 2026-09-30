using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ClasesP.Models
{
    public class Cancion
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public double Duracion { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
       
       

    }
}
