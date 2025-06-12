using System.Threading.Tasks;

namespace OCR.SimultaniousLogin.Data;

public interface ISimultaniousLoginDbSchemaMigrator
{
    Task MigrateAsync();
}
