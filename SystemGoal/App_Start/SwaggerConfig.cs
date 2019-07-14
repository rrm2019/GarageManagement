using System.Web.Http;
using WebActivatorEx;
using SystemGoal;
using Swashbuckle.Application;
using System;
using System.Linq;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SystemGoal
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SystemGoal.xml");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\SystemGoal.xml", AppDomain.CurrentDomain.BaseDirectory));
                        c.IgnoreObsoleteProperties();
                        c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("Example of Swagger use");
                        c.DocExpansion(DocExpansion.List);
                    });
        }
    }
}
