using Tedu.Ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tedu.Ecommerce;

[DependsOn(
    typeof(EcommerceEntityFrameworkCoreTestModule)
    )]
public class EcommerceDomainTestModule : AbpModule
{

}
