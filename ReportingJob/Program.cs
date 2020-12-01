using Infrastructure.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ReportingJob
{
    public class Program
    {
        public void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<Worker>().Run("ReportJob");
        }
    }
}
