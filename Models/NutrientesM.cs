using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Models
{
    public class NutrientesM
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int heladoId { get; set; }
        public int subId { get; set; }
    }
}
