using Newtonsoft.Json;
using sistemaEtiquetasHelados.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEtiquetasHelados.Servicios
{
    internal class Etiqueta_API : IEtiqueta
    {
        public async Task<string> ImprimirEtiquetaAsync(EtiquetaRequest etiquetaRequest, int heladoId, int envaseId)
        {
            string url = Router.ImprimirEtiquetaConParametros(heladoId, envaseId);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Accept", "application/pdf"); 

                var jsonContent = JsonConvert.SerializeObject(etiquetaRequest);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    byte[] pdfData = await response.Content.ReadAsByteArrayAsync();

                    string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "ArchivosPDF");
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string fileName = $"etiqueta_{heladoId}_{envaseId}_{timestamp}.pdf";
                    string filePath = Path.Combine(folderPath, fileName);

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                    {
                        await fileStream.WriteAsync(pdfData, 0, pdfData.Length);
                    }


                    Process.Start(new ProcessStartInfo
                    {
                        FileName = folderPath,
                        UseShellExecute = true,
                        Verb = "open"
                    });

                    return $"Archivo PDF guardado exitosamente en: {filePath}";
                }
                else
                {
                    throw new Exception($"Error al imprimir la etiqueta: {response.ReasonPhrase}");
                }
            }
        }

    }
}
