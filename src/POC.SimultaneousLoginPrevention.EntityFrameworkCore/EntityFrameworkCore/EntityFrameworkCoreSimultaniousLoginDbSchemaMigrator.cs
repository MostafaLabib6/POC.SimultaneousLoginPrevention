using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OCR.SimultaniousLogin.Data;
using Volo.Abp.DependencyInjection;

namespace OCR.SimultaniousLogin.EntityFrameworkCore;

public class EntityFrameworkCoreSimultaniousLoginDbSchemaMigrator
    : ISimultaniousLoginDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSimultaniousLoginDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SimultaniousLoginDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SimultaniousLoginDbContext>()
            .Database
            .MigrateAsync();
    }
}
