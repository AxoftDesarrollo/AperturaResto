using AperturaRestoService.Dto;
using System;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace AperturaRestoService.Api
{
    public class FacturaController : BaseController
    {
        private void LogData(FacturaDto data)
        {
            Log.Info("Detalle de la factura");
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
            Log.Info("Json Facturación");
            var json = new JavaScriptSerializer().Serialize(data);
            Log.Info(json);
        }

        [HttpPost]
        public IHttpActionResult AfterInsert(FacturaDto data)
        {
            try
            {
                Log.Debug("FacturaController.AfterInsert: Inicio");
                // Desarrollo de lógica de apertura
                LogData(data);
                // Fin de lógica de apertura
                Log.Debug("FacturaController.AfterInsert: Fin");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Fatal("FacturaController.AfterInsert", e);
                return InternalServerError();
            };
        }
    }
}
