using ClasesP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesP.Repositories
{
    public class repocancion
    {
        public List<Cancion> ObtenerOrdenados(List<Cancion> canciones)
        {
            return canciones.OrderBy(e => e.Titulo)
                            .ToList();
        }
    }
}
