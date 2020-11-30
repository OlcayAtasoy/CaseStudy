using Infrastructure.DataModel.Impl;
using Infrastructure.DataModel.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.DataModel
{
    public static class Ioc
    {
        public static void IocRepositoryInstall(this IServiceCollection services)
        {
            services.AddScoped<IDirectoryRepository, DirectoryRepository>();
            services.AddScoped<ICommunicationInformationRepository, CommunicationInformationRepository>();
        }
    }
}
