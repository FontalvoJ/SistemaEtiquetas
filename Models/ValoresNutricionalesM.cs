using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Models
{
    public class ValoresNutricionalesM
    {
        public int id { get; set; }
        public float cantidad { get; set; }
        public string unidad { get; set; }
        public int vd { get; set; }
        public int nutrienteId { get; set; }
    }
}
