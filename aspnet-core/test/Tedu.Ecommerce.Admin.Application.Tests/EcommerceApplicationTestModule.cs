using Volo.Abp.Modularity;

namespace Tedu.Ecommerce.Admin;

[DependsOn(
    typeof(EcommerceAdminApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceApplicationTestModule : AbpModule
{

}
