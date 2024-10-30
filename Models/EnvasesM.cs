using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Models
{
    public class EnvasesM
    {
        public int id { get; set; }

        [JsonPropertyName("base")]
        public float Base { get; set; }

        public float altura { get; set; }

        public string figura { get; set; }
        public float etiquetaAlto { get; set; }
        public float etiquetaAncho { get; set; }
        public int CalcularVolumen()
        {
            double radio = Base / 2;
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;
            return (int)Math.Round(volumen);
        }

        public override string ToString()
        {
            return $"{CalcularVolumen()} cm³";
        }
    }
}
