using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistemaEtiquetasHelados.Servicios.Envases_API;

namespace sistemaEtiquetasHelados.Servicios
{
    public interface IEnvases
    {
        Task<List<EnvasesM>> ObtenerEnvasesPorHelado(string heladoId);
    }
}
