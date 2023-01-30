using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace projektowanie_oprogramowania_final_project.tests
{
    public class Utilities
    {
        
        public static DbContextOptions<CinemaDbContext> TestDbContextOptions()
        {
            // Create a new service provider to create a new in-memory database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            // Create a new options instance using an in-memory database and 
            // IServiceProvider that the context should resolve all of its 
            // services from.
            var builder = new DbContextOptionsBuilder<CinemaDbContext>()
                .UseInMemoryDatabase("CinemaDb")
                .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
        
    }
}
