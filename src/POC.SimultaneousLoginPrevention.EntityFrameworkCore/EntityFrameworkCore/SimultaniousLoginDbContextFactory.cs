using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OCR.SimultaniousLogin.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SimultaniousLoginDbContextFactory : IDesignTimeDbContextFactory<SimultaniousLoginDbContext>
{
    public SimultaniousLoginDbContext CreateDbContext(string[] args)
    {
        SimultaniousLoginEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SimultaniousLoginDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SimultaniousLoginDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../POC.SimultaneousLoginPrevention.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
