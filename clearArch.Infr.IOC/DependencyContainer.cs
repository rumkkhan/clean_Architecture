using ClearAarch.Infra.Data.Repository;
using clearArch.Applicaiton.Interfaces;
using clearArch.Applicaiton.Services;
using ClearArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace clearArch.Infr.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Infra.Data Layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
