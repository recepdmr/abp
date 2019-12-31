using Volo.Abp.Modularity;

namespace Volo.Abp.MultiTenancy.Tests
{
    [DependsOn(typeof(AbpMultiTenancyModule))]
    public class MultiTenancyTestModule : AbpModule
    {
        
    }
}