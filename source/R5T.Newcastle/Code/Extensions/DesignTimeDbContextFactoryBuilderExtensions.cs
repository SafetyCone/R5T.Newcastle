using System;

using R5T.Richmond;


namespace R5T.Newcastle
{
    public static class DesignTimeDbContextFactoryBuilderExtensions
    {
        public static IServiceProvider UseStartupNewcastle<TStartup>(this DesignTimeDbContextFactoryBuilder designTimeDbContextFactoryBuilder)
            where TStartup: ApplicationStartupBase, IDesignTimeDbContextFactoryStartup
        {
            var serviceProvider = designTimeDbContextFactoryBuilder.UseStartup<TStartup,
                DesignTimeDbContextFactoryApplicationConfigurationStartup,
                DesignTimeDbContextFactoryApplicationConfigurationConfigurationStartup>();

            return serviceProvider;
        }
    }
}
