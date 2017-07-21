using AperturaRestoService.Dto;
using System;
using System.Web.Http;
using System.Net.Http;

namespace AperturaRestoService
{
    public class ComandaController: BaseController
    {
        private void LogData (ComandaDto data)
        {
            Log.Info("Detalle de comanda");
            Log.Info(data.ComandaId);
            Log.Info(data.Fecha);
            Log.Info(data.Hora);
            Log.Info(data.Estado);
            Log.Info(data.Total);
            Log.Info("Detalle de renglones");
            if (data.Detalle != null)
            {
                foreach (var renglon in data.Detalle)
                {
                    string line = $"{renglon.NumeroRenglon};{renglon.CodigoArticulo}; ;{renglon.Cantidad}; ;{renglon.Importe}";
                    Log.Info(line);
                }
            }
        }

        [HttpPost]
        public IHttpActionResult AfterSend(ComandaDto data)
        {
            try
            {
                Log.Debug("ComandaController.AfterSend: Inicio");
                // Desarrollo de lógica de apertura
                LogData(data);
                // Fin de lógica de apertura
                Log.Debug("ComandaController.AfterSend: Fin");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Fatal("ComandaController.AfterSend", e);
                return InternalServerError();
            };
        }
    }
}
