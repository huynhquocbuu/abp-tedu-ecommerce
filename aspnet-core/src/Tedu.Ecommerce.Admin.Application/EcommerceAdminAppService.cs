using System;
using System.Collections.Generic;
using System.Text;
using Tedu.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace Tedu.Ecommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAdminAppService : ApplicationService
{
    protected EcommerceAdminAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
