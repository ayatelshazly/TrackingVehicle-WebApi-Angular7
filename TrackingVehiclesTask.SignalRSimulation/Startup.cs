using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;


namespace TrackingVehiclesTask.Api.SignalR
{
    public class Startup
    {
        //    public void Configuration(IAppBuilder app)
        //    {
        //        // Any connection or hub wire up and configuration should go here
        //        app.MapSignalR();
        //    }
        //}

        public void Configuration(IAppBuilder app)
        {
          
            app.Map("/signalr", map =>
            {             
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                   
                };
            

                hubConfiguration.EnableDetailedErrors = true;
                map.RunSignalR(hubConfiguration);
            });
        }
    }
}