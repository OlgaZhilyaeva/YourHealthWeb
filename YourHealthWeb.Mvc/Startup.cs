using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Core;
using YourHealthWeb.DAL;
using YourHealthWeb.Models;

namespace YourHealthWeb.Mvc
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
            string con = "Server=tcp:hlp.database.windows.net,1433;Initial Catalog=hlp-database;Persist Security Info=False;User ID=Helga;Password=HeaLTHprOjEct2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(con));
            
            // Add application services.
            services.AddTransient<IPatientProvider, PatientProvider>();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddTransient<ITemperatureProvider, TemperatureProvider>();
            services.AddTransient<IRepository<Temperature>, TemperatureRepository>();
            services.AddTransient<IDepartmentProvider, DepartmentProvider>();
            services.AddTransient<IRepository<Department>, DepartmentRepository>();
            services.AddTransient<IWardProvider, WardProvider>();
            services.AddTransient<IRepository<Ward>, WardRepository>();
            services.AddTransient<IUserProvider, UserProvider>();
            services.AddTransient<IRepository<HospitalUser>, UserRepository>();
            services.AddTransient<IDoctorProvider, DoctorProvider>();
            services.AddTransient<IRepository<Doctor>, DoctorRepository>();
            services.AddTransient<INurseProvider, NurseProvider>();
            services.AddTransient<IRepository<Nurse>, NurseRepository>();
            services.AddTransient<IHospitalProvider, HospitalProvider>();
            services.AddTransient<IRepository<Hospital>, HospitalRepository>();
            services.AddTransient<ISensorProvider, SensorProvider>();
            services.AddTransient<IRepository<Sensor>, SensorRepository>();
            services.AddTransient<IMedicineProvider, MedicineProvider>();
            services.AddTransient<IRepository<Medicine>, MedicineRepository>();
            services.AddTransient<IPrescriptionProvider, PrescriptionProvider>();
            services.AddTransient<IRepository<Prescription>, PrescriptionRepository>();



            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=PatientList}/{id?}");
            });
        }
    }
}
