using Newtonsoft.Json;
using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Servicios
{
    internal class Helados_API : IHelados
    {
        private static string url = Router.Helados;


        public async Task<List<HeladosM>> ObtenerHeladosPorProductor(string productorId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string urlHeladosPorProductor = $"{Router.Productores}/{productorId}?incluir=helados";
                    HttpResponseMessage response = await client.GetAsync(urlHeladosPorProductor);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    
                    var productorConHelados = JsonConvert.DeserializeObject<ProductoresM>(responseBody);

                 
                    return productorConHelados.helados;
                }
                catch (HttpRequestException httpEx)
                {
                    throw new Exception("Error en la solicitud HTTP: " + httpEx.Message);
                }
                catch (JsonException jsonEx)
                {
                    throw new Exception("Error al deserializar los datos: " + jsonEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error desconocido: " + ex.Message);
                }
            }
        }
    }
}
