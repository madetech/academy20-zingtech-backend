using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using academy20_zingtech_backend.Models;
using Npgsql;
using Microsoft.AspNetCore.Cors;

namespace academy20_zingtech_backend
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
            //other service configuration goes here...
            //pull in connection string
            string connectionString = null;
            string envVar = Environment.GetEnvironmentVariable("DATABASE_URL");
            if (string.IsNullOrEmpty(envVar)){
                connectionString = Configuration["Connectionstrings:DefaultConnection"];
            }
            else{
                
                var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
                var databaseUri = new Uri(databaseUrl);
                var userInfo = databaseUri.UserInfo.Split(':');

                var builder = new NpgsqlConnectionStringBuilder
                {
                    Host = databaseUri.Host,
                    Port = databaseUri.Port,
                    Username = userInfo[0],
                    Password = userInfo[1],
                    Database = databaseUri.LocalPath.TrimStart('/')
                };

                connectionString = builder.ToString();
                /*//parse database URL. Format is postgres://<username>:<password>@<host>/<dbname>
                var uri = new Uri(envVar);
                var username = uri.UserInfo.Split(':')[0];
                var password = uri.UserInfo.Split(':')[1];
                connectionString = 
                    "; Database=" + uri.AbsolutePath.Substring(1) +
                    "; Username=" + username +
                    "; Password=" + password + 
                    "; Port=" + uri.Port +
                    "; SSL Mode=Require; Trust Server Certificate=true;";*/
            }
            services.AddDbContext<EmployeeDatumContext>(opt =>
                opt.UseNpgsql(connectionString)
            );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder => builder.AllowAnyOrigin());
            });

        }
        
        /*
        {
            services.AddDbContext<EmployeeDatumContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
         }   
        */
        

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

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseCors();
        }
    }
}