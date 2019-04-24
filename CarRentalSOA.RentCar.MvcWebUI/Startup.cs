using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.Business.Concrete;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CarRentalSOA.RentCar.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<AracBilgiService, AracBilgiManager>();
            services.AddScoped<DataAccess.Abstract.IAracBilgiDataAccesLayer, EfAracBilgiDataAccesLayer>();
            services.AddMvc();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
