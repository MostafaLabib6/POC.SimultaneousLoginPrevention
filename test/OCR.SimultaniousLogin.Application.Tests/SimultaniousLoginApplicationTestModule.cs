using Volo.Abp.Modularity;

namespace OCR.SimultaniousLogin;

[DependsOn(
    typeof(SimultaniousLoginApplicationModule),
    typeof(SimultaniousLoginDomainTestModule)
)]
public class SimultaniousLoginApplicationTestModule : AbpModule
{

}
