using System.Web.Http;

namespace AperturaRestoService
{
    public class TestController: BaseController
    {
        [HttpGet]
        public string Test()
        {
            Log.Debug("Ejecución del metodo Test");
            return "Estoy activo";
        }
    }
}
