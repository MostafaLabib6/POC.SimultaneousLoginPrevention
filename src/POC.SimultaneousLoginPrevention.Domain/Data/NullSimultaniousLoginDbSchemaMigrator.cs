using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OCR.SimultaniousLogin.Data;

/* This is used if database provider does't define
 * ISimultaniousLoginDbSchemaMigrator implementation.
 */
public class NullSimultaniousLoginDbSchemaMigrator : ISimultaniousLoginDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
