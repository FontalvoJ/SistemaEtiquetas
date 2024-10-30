﻿using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistemaEtiquetasHelados.Servicios.Productores_API;


namespace sistemaEtiquetasHelados.Servicios
{
    public interface IProductores
    {
        Task<List<ProductoresM>> ObtenerProductores();
    }
}
