using System;
using System.Collections.Generic;
using System.Text;
using tokenAuth.Localization;
using Volo.Abp.Application.Services;

namespace tokenAuth;

/* Inherit your application services from this class.
 */
public abstract class tokenAuthAppService : ApplicationService
{
    protected tokenAuthAppService()
    {
        LocalizationResource = typeof(tokenAuthResource);
    }
}
