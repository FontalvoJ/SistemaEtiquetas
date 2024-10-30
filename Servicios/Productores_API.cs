using sistemaEtiquetasHelados.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using JsonException = Newtonsoft.Json.JsonException;

namespace sistemaEtiquetasHelados.Servicios
{
    internal class Productores_API : IProductores
    {
        private static string url = Router.Productores;

        public async Task<List<ProductoresM>> ObtenerProductores()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();


                    string responseBody = await response.Content.ReadAsStringAsync();


                    List<ProductoresM> productores = JsonConvert.DeserializeObject<List<ProductoresM>>(responseBody);
                    return productores;
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
