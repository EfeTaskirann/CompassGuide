using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CompassGuide.Ioc
{
    namespace CompassGuide.Ioc
    {
        public class ConfigureServices
        {
            public void Configure(ServiceCollection services)
            {
                services.AddControllers();

                services.AddDbContext<CompassGuide>(options =>
                    options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            }
        }
    }



}


