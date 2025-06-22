using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Second.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SecondDbContextFactory : IDesignTimeDbContextFactory<SecondDbContext>
{
    public SecondDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        SecondEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<SecondDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new SecondDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Second.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
