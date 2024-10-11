using BusinessLogic;
using DataAccess.Context;
using DataAccess.Repositories;
using IBusinessLogic;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APIServiceFactory
{
    public static class ServiceFactory
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieLogic, MovieLogic>();
            serviceCollection.AddScoped<IMovieRepository, MovieRepository>();
            
            serviceCollection.AddScoped<IImporterLogic, ImporterLogic>();
        }

        public static void AddConnectionString(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<DbContext, MovieContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
