using Xunit;

namespace OCR.SimultaniousLogin.EntityFrameworkCore;

[CollectionDefinition(SimultaniousLoginTestConsts.CollectionDefinitionName)]
public class SimultaniousLoginEntityFrameworkCoreCollection : ICollectionFixture<SimultaniousLoginEntityFrameworkCoreFixture>
{

}
