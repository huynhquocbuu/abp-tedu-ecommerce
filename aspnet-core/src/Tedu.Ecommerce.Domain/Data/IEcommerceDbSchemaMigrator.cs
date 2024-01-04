using System.Threading.Tasks;

namespace Tedu.Ecommerce.Data;

public interface IEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
