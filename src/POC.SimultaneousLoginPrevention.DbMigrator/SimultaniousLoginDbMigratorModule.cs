using OCR.SimultaniousLogin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OCR.SimultaniousLogin.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SimultaniousLoginEntityFrameworkCoreModule),
    typeof(SimultaniousLoginApplicationContractsModule)
    )]
public class SimultaniousLoginDbMigratorModule : AbpModule
{
}
