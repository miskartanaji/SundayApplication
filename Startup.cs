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
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SundayMobilityApplication.Implementation;
using SundayMobilityApplication.IStudentServices;
using SundayMobilityApplication.Models;

namespace SundayMobilityApplication
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
            services.AddControllers();
            // Added swagger DI
            services.AddSwaggerGen(o =>
            { 
                o.SwaggerDoc("v1", new OpenApiInfo { Title = "MY API", Version = "v1" }); 
            });
            services.AddControllers();
            services.AddHttpClient();
            // Db  and connection
            services.AddDbContext<StudentDatabaseContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            // Service Interface
            services.AddTransient<IStudentService, StudentService>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Swagger
            app.UseSwagger();
            app.UseSwaggerUI(o => 
            { 
                o.SwaggerEndpoint("/swagger/v1/swagger.json", "MY API V1"); 
            });
        }
    }
}
