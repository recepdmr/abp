using System.Threading.Tasks;

namespace Volo.Abp.Data.Seeding
{
    public interface IDataSeedContributor
    {
        Task SeedAsync(DataSeedContext context);
    }
}