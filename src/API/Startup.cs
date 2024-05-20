using API.Presistence;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;

namespace API
{
    public class Startup(IConfiguration config)
    {
        private readonly IConfiguration _config = config;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("SQLServerDefaultConnection"));
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson(cfg =>
            {

            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(policy => {
                policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
