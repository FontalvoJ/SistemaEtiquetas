using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Models
{
    public class HeladosM
    {
        public int id { get; set; }
        public string ingredientes { get; set; }
        public string observacion { get; set; }
        public string nombre { get; set; }
        public int productorId { get; set; }

        public List<EnvasesM> envases { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
}
