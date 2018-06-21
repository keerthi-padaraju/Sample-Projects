using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using BooksAPI.Core;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BooksAPI
{

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new Initializer());

            //Configure application to return Camel-case JSON instead of defaulat Pascal-case
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //Restrict access to all endpoints to the requests that have been authenticated
            GlobalConfiguration.Configure(FilterConfig.Configure);
        }
    }
}