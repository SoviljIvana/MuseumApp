using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenSourceSoftwareDevelopment.Museum.API.ServiceExtensions;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Services;
using OpenSourceSoftwareDevelopment.Museum.Repositories;

namespace OpenSourceSoftwareDevelopment.Museum.API
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
            services.AddDbContext<MuseumContext>(options =>
            {
                options
                .UseSqlServer(Configuration.GetConnectionString("MuseumConnection"))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            services.AddJwtBearerAuthentication(Configuration);
            services.AddControllers();
            services.AddOpenApi();


            // Repositories
            services.AddTransient<IAuditoriumsRepository, AuditoriumsRepository>();
            services.AddTransient<IExhibitionsRepository, ExhibitionsRepository>();
            services.AddTransient<IExhibitsRepository, ExhibitsRepository>();
            services.AddTransient<IMuseumsRepository, MuseumsRepository>();
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<ITicketsRepository, TicketsRepository>();

            // Business Logic
            services.AddTransient<IAuditoriumService, AuditoriumService>();
            services.AddTransient<IExhibitionService, ExhibitionService>();
            services.AddTransient<IExhibitService, ExhibitService>();
            services.AddTransient<IMuseumService, MuseumService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITicketService, TicketService>();

            // Allow Cors for client app
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    corsBuilder => corsBuilder.WithOrigins("http://localhost:3000")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
       
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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}