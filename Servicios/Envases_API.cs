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
    internal class Envases_API : IEnvases
    {

        public async Task<List<EnvasesM>> ObtenerEnvasesPorHelado(string heladoId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string urlEnvasesPorHelado = Router.EnvasesPorHelado(heladoId);
                    HttpResponseMessage response = await client.GetAsync(urlEnvasesPorHelado);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                   
                    var heladoConEnvases = JsonConvert.DeserializeObject<HeladosM>(responseBody);

                   
                    return heladoConEnvases.envases ?? new List<EnvasesM>();
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
