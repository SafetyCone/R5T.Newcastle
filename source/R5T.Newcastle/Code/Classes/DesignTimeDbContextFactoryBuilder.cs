using System;

using R5T.Coventry;
using R5T.Derby;

using RichmondApplicationBuilder = R5T.Richmond.ApplicationBuilder;


namespace R5T.Newcastle.Code.Classes
{
    public static class DesignTimeDbContextFactoryBuilder
    {
        public static IServiceProvider UseStartup<TStartup, TConfigurationStartup>()
            where TStartup: ApplicationStartupBase, IDesignTimeDbContextFactoryStartup
            where TConfigurationStartup: ApplicationConfigurationStartup
        {
            var serviceProvider = RichmondApplicationBuilder.UseStartup<TStartup, TConfigurationStartup>();
            return serviceProvider;
        }

        public static IServiceProvider UseStartup<TStartup>()
            where TStartup : ApplicationStartupBase, IDesignTimeDbContextFactoryStartup
        {
            var serviceProvider = RichmondApplicationBuilder.UseStartup<TStartup, ApplicationConfigurationStartup>();
            return serviceProvider;
        }
    }
}
