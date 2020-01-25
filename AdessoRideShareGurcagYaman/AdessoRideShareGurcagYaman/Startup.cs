using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AdessoRideShareGurcagYaman.DataAccessLayer.Interfaces;
using AdessoRideShareGurcagYaman.DataAccessLayer.Repositories;
using AdessoRideShareGurcagYaman.DataAccessLayer.Entities;
using AdessoRideShareGurcagYaman.BusinessService.Interfaces;
using AdessoRideShareGurcagYaman.BusinessService.Repositories;

namespace AdessoRideShareGurcagYaman
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IGenericRepository<Passenger>, GenericRepository<Passenger>>()
                .AddScoped<IGenericRepository<Driver>, GenericRepository<Driver>>()
                .AddScoped<IGenericRepository<Trip>, GenericRepository<Trip>>()
                .AddScoped<IGenericRepository<TripRequest>, GenericRepository<TripRequest>>()
                .AddScoped<IGenericRepository<Vehicle>, GenericRepository<Vehicle>>()
                .AddScoped<IGenericRepository<Location>, GenericRepository<Location>>()
                .AddScoped<IDriverBusinessService, DriverBusinessService>()
                .AddScoped<IPassengerBusinessService, PassengerBusinessService>()
                .AddScoped<ITripBusinessService, TripBusinessService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMiddleware(typeof(Core.ExceptionHandler));

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
