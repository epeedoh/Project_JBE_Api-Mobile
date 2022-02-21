using Jbl.API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.Reflection;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;
using Jbl.API.IRepository;
using Jbl.API.Repository;
using Microsoft.OpenApi.Models;

namespace Jbl.API
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
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddAutoMapper();

            services.AddScoped<IStageRepository, StageRepository>();
            services.AddScoped<INiveauRepository, NiveauRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IThemeRepository, ThemeRepository>();
            services.AddScoped<IReponseRepository, ReponseRepository>();

            //services.AddCors();
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()           //Fix API ISSUE
                                                                 .AllowAnyMethod()               //Fix API ISSUE
                                                                  .AllowAnyHeader()));           //Fix API ISSUE

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            //  services.UseSwaggerU
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JBE.API v1"));

            }



            //app.UseSwagger();
            //          app.UseSwaggerUI(c =>
            //          {
            //              c.SwaggerEndpoint("/swagger/v1/swagger.json", "SIH API V1");
            //          });

            //app.UseSwaggerUI(c =>
            //{
            //    c.RoutePrefix = "swagger";
            //    c.SwaggerEndpoint("v1/swagger.json", "My API V1");
            //});


        

           // app.UseCors("AllowAll");

            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) // allow any origin
               .AllowCredentials()); // allow credentials

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
