using Volo.Abp.Modularity;

namespace Tedu.Ecommerce;

[DependsOn(
    typeof(EcommerceApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceApplicationTestModule : AbpModule
{

}
