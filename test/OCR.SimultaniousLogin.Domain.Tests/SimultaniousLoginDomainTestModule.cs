using Volo.Abp.Modularity;

namespace OCR.SimultaniousLogin;

[DependsOn(
    typeof(SimultaniousLoginDomainModule),
    typeof(SimultaniousLoginTestBaseModule)
)]
public class SimultaniousLoginDomainTestModule : AbpModule
{

}
