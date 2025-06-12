using Volo.Abp.Modularity;

namespace OCR.SimultaniousLogin;

public abstract class SimultaniousLoginApplicationTestBase<TStartupModule> : SimultaniousLoginTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
