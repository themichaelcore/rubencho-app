using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rubencho.Persistence.Abstractions;

namespace Rubencho.Persistence  
{
    public class RubenchoDbContextInitializer : IDbContextInitializer
    {
        private readonly RubenchoDbContext context;
        //private readonly ILogger logger;

        public RubenchoDbContextInitializer(RubenchoDbContext context)
        {
            this.context = context;
        }

        //public RubenchoDbContextInitializer(RubenchoDbContext context, ILogger logger)
        //{
        //    this.context = context;
        //    //this.logger = logger;
        //}

        public async Task InitializeAsync()
        {
            try
            {
                if (context.Database.IsSqlServer())
                {
                    await context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                //    logger.LogError(ex, "An error occurred while initialising the database.");
                //    throw;
            }
        }
    }
}
