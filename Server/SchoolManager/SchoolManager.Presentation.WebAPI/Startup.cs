using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManager.Application.Service;
using SchoolManager.Domain.Business.Repositories;
using SchoolManager.Domain.Model;
using SchoolManager.InfraStructure.Data;
using SchoolManager.InfraStructure.EFProvider;
using SchoolManager.InfraStructure.MockProvider;
using SchoolManager.InfraStructure.Repository;

namespace SchoolManager.Presentation.WebAPI
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
            

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            services.AddControllers();

            services.AddTransient<ISchoolService, SchoolService>();
            services.AddTransient<ISchoolRepository<SchoolModel>, SchoolRepository>();
            
            //services.AddTransient<IProvider<Domain.Model.SchoolModel>, SchoolMockProvider>();
            
            services.AddTransient<IProvider<Domain.Model.SchoolModel>, SchoolProvider>();
            services.AddDbContext<InfraStructure.EFProvider.SchoolManagerContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("SchoolManagerContext")));
            services.AddScoped<SchoolManagerContext>();

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

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}