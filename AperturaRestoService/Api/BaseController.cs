using log4net;
using System.Web.Http;

namespace AperturaRestoService
{
    public class BaseController : ApiController
    {
        protected readonly ILog Log = log4net.LogManager.GetLogger("AperturaRestoServiceLogger");
        public BaseController()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
