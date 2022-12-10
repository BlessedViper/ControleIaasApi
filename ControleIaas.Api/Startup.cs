using ControleIaas.Api.Mapping;
using ControleIaas.Domain.Interface;
using ControleIaas.Domain.Interface.Commands;
using ControleIaas.Infra.Context;
using ControleIaas.Infra.Repository.commands;
using ControleIaas.Infra.Repository.DataPersist;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ControleIaas.Api
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DataContext>(opts =>
            {
                opts
                .UseSqlServer(Configuration.GetConnectionString("ControleVersao"));
            });

            //Data
            services.AddScoped<DataContext>();
            //AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));
            //Repository
            services.AddTransient<IDeleteObject, DeleteObject>();
            services.AddTransient<IGetObjectFilter, GetObject>();
            services.AddTransient<IPostObject, PostObject>();
            services.AddTransient<IGetObject, GetObjectNoFilter>();
            services.AddTransient<IUpdateObject, UpdateObject>();
            services.AddTransient<IActiveObject, ActiveObject>();
            services.AddTransient<IGetInstanciasCommand, GetInstanciasCommand>();
            services.AddTransient<IGetInstanciasFiltroCommand, GetInstanciasFiltroCommand>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ControleIaaSAPI", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "ControleIaaS API V1"); });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
