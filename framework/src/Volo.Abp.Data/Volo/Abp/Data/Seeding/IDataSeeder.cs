using System.Threading.Tasks;

namespace Volo.Abp.Data.Seeding
{
    public interface IDataSeeder
    {
        Task SeedAsync(DataSeedContext context);
    }
}