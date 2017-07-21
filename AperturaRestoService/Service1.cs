using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace AperturaRestoService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:9100");
            config.Routes.MapHttpRoute(
                name: "API",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });

            var server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
        }

        protected override void OnStop()
        {
        }
    }
}
