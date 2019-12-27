using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Derby;
using R5T.Shrewsbury;
using R5T.Shrewsbury.Default;


namespace R5T.Newcastle
{
    public class DesignTimeDbContextFactoryApplicationConfigurationStartup : ApplicationConfigurationStartup
    {
        public DesignTimeDbContextFactoryApplicationConfigurationStartup(ILogger<DesignTimeDbContextFactoryApplicationConfigurationStartup> logger)
            : base(logger)
        {
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            base.ConfigureServicesBody(services);

            // Use the current directory for the EF tools, not the executable directory.
            services
                .AddSingleton<IAppSettingsDirectoryPathProvider, CurrentDirectoryAppSettingsDirectoryPathProvider>()
                ;
        }
    }
}
