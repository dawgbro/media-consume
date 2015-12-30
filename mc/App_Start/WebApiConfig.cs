using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace mc
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
            );


            //    config.Routes.MapHttpRoute(
            //  name: "SerialDownload",
            //  routeTemplate: API_Version_Prefix + "/Integrations/SerialDownload/",
            //  defaults: new { version = AppSettingsWrapper.DefaultESMSVersion, action = "SerialDownload", controller = "Integrations" },
            //  constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
            //);
        }
    }
}
