using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace tokenAuth;

public class tokenAuthWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<tokenAuthWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
