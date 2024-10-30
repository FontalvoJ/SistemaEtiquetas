using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static sistemaEtiquetasHelados.Servicios.Helados_API;

namespace sistemaEtiquetasHelados.Servicios
{
    public interface IHelados
    {
        Task<List<HeladosM>> ObtenerHeladosPorProductor(string productorId);

    }
}
