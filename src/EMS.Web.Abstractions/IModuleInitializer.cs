using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EMS.Web.Abstractions
{
    public interface IModuleInitializer
    {
        string ModuleName { get; }
        IServiceCollection ConfigureServices(IServiceCollection services);
        IApplicationBuilder Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory);
    }
}