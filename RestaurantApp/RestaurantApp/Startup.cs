using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using RestaurantApp.Database;
using Npgsql;
using RestaurantApp.Repository;
using AutoMapper;
using RestaurantApp.Mapper;

namespace RestaurantApp
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
            //services.AddDbContext<RestaurantAppDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString(("DefaultConnection"))));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<RestaurantAppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDishItemRepository, DishItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPriceItemRepository, PriceItemRepository>();
            services.AddAutoMapper(c => c.AddProfile<Automap>(), typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Pizzeria API",
                    Description = "Bardzo prosty przykład API opartego o ASP.NET Core Web API",
                    TermsOfService = new Uri("https://wsb.pl/courses"),
                    Contact = new OpenApiContact
                    {
                        Name = "WSB Poznań",
                        Email = string.Empty,
                        Url = new Uri("https://wsb.pl"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Licencja",
                        Url = new Uri("https://wsb.pl/licencja"),
                    }
                });
            });
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAllOrigins", 
                    builder => builder
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowAnyOrigin()
                              );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowAllOrigins");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
