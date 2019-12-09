using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;

using R5T.Coventry;
using R5T.Venetia;
using R5T.Venetia.Extensions;


namespace R5T.Newcastle
{
    public class DesignTimeDbContextFactoryStartupBase<TConnectionStringProvider, TDatabaseContextOptionsBuilderConfigurator>
        : ApplicationStartupBase, IDesignTimeDbContextFactoryStartup
        where TConnectionStringProvider : class, IConnectionStringProvider
        where TDatabaseContextOptionsBuilderConfigurator : class, IDatabaseContextOptionsBuilderConfigurator
    {
        public DesignTimeDbContextFactoryStartupBase(ILogger<DesignTimeDbContextFactoryStartupBase<TConnectionStringProvider, TDatabaseContextOptionsBuilderConfigurator>> logger)
            : base(logger)
        {
        }

        protected void AddDatabaseContext<TDbContext>(IServiceCollection services)
            where TDbContext : DbContext
        {
            services.AddDatabaseContext<TDbContext, TConnectionStringProvider, TDatabaseContextOptionsBuilderConfigurator>();
        }
    }
}
