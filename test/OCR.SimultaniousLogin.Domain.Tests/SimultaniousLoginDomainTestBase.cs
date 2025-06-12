using Volo.Abp.Modularity;

namespace OCR.SimultaniousLogin;

/* Inherit from this class for your domain layer tests. */
public abstract class SimultaniousLoginDomainTestBase<TStartupModule> : SimultaniousLoginTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
