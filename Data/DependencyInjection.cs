using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VoteMap.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VoteMapDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("VoteMapDatabase"), 
                    x => x.UseNetTopologySuite()));
            return services;
        }
    }
}
