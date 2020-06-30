﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Atomiv.Template.Infrastructure.Domain.Persistence.Common;

namespace Atomiv.Template.Tools.Migrator
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            // TODO: VC: Handling multiple environments

            // var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var environment = "Development";
            // throw new Exception("Environment " + environment);

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{environment}.json", true);

            var configuration = configurationBuilder.Build();


            // TODO: VC: Check if dependency is allowed
            var connectionKey = "DefaultConnection"; // TODO: VC:
            var connection = configuration.GetConnectionString(connectionKey);

            // TODO: VC: Perhaps make some external migrator console app?

            // throw new Exception("Connection is: " + connection);

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(connection, options => options.MigrationsAssembly("Atomiv.Template.Tools.Migrator"));

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}