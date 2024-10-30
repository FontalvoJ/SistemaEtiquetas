

namespace sistemaEtiquetasHelados
{
    internal class Router
    {
        static string url_deploy = "https://destored-helados-etiquetas-api-production.up.railway.app/api/v1";

        static public string Helados { get { return url_deploy + "/helados"; } }
        static public string Productores { get { return url_deploy + "/productores"; } }
        static public string Envases { get { return url_deploy + "/envases"; } }
        static public string ImprimirEtiqueta { get { return url_deploy + "/etiquetas/imprimir"; } }

        static public string ProductorConHelados(string productorId)
        {
            return $"{url_deploy}/productores/{productorId}?incluir=helados";
        }

        public static string EnvasesPorHelado(string heladoId)
        {
            return $"{url_deploy}/helados/{heladoId}?incluir=envases";
        }

        static public string ImprimirEtiquetaConParametros(int heladoId, int envaseId)
        {
            return $"{ImprimirEtiqueta}?heladoId={heladoId}&envaseId={envaseId}";
        }
    }
}
