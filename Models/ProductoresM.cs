using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Models
{
    public class ProductoresM
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string rne { get; set; }
        public string rnpa { get; set; }
        public string logo { get; set; }

        public override string ToString()
        {
            return nombre;
        }

        public List<HeladosM> helados { get; set; }
    }
}
