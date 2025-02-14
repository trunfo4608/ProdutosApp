using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ProdutosApp.Extension
{
    public static class SwaggerExtension
    {

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Produtos App - API para controle de produtos.",
                    Description = "API desenvolvida em .Net 7 com EF Core.",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Renato vasconcelos",
                        Email = "trunfo4608@gmail.com",
                        Url = new Uri("http://www.rav@solcucoes.com.br")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                options.IncludeXmlComments(xmlPath);

            });

            return services;
        }


        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        { 
           app.UseSwagger();
           app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "ProdutosApp")
            );

            return app;
        }

        
    }
}
