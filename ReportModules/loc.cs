using DirectoryModules.Contracts;
using DirectoryModules.WorkFlows;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DirectoryModules
{
    public static class loc
    {
        public static void IocModuleInstall(this IServiceCollection services)
        {
            services.AddTransient<IReportContract, ReportWorkFlow>();
        }
    }
}
