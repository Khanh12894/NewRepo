using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WepApp.Repository.Implements;
using WepApp.Repository.Interfaces;
using WepApp.Repository.Models;

namespace WepApp.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IOrder, OrderRepository>();
            
            services.AddDbContext<DataContext>(opt => opt
                .UseSqlServer("Server=DESKTOP-UUBJ14C\\SQLEXPRESS; Database=OrderDb;Trusted_Connection=True;"));
            return services;
        }
    }
}
