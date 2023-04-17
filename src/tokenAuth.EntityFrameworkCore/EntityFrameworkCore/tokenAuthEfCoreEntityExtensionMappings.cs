using Microsoft.EntityFrameworkCore;
using System;
using tokenAuth.Users;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace tokenAuth.EntityFrameworkCore;

public static class tokenAuthEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        tokenAuthGlobalFeatureConfigurator.Configure();
        tokenAuthModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            ObjectExtensionManager.Instance
            .MapEfCoreProperty<IdentityUser, bool>(
                "IsOnline", 
                (entityBuilder, propertyBuilder) => {
                    propertyBuilder.HasDefaultValue(false);
                });
        });
    }
}
