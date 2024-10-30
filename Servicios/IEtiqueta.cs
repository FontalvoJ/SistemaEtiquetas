using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Servicios
{
    public interface IEtiqueta
    {
        Task<string> ImprimirEtiquetaAsync(EtiquetaRequest etiquetaRequest, int heladoId, int envaseId);
    }
}
