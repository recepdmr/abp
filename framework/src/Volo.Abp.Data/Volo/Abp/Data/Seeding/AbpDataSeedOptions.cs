namespace Volo.Abp.Data.Seeding
{
    public class AbpDataSeedOptions
    {
        public DataSeedContributorList Contributors { get; }

        public AbpDataSeedOptions()
        {
            Contributors = new DataSeedContributorList();
        }
    }
}
