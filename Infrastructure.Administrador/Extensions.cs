using Application.Administrador;
using Domain.Administrador.Repositories;
using Infrastructure.Administrador.EF;
using Infrastructure.Administrador.EF.Context;
using Infrastructure.Administrador.EF.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Administrador
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddApplication();
            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AdministradorConnectionString"));
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AdministradorConnectionString"));
            });

            //Scoped: se crea una instancia por cada request
            //Transient: se crea una instancia por cada uso
            //Singleton: se crea una instancia por cada aplicación
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IChoferRepository, ChoferRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IVendedorRepository, VendedorRepository>();


            return services;
        }
        
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }

    }
}
