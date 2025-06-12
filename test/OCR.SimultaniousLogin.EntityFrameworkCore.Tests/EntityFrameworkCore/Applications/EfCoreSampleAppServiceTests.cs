using OCR.SimultaniousLogin.Samples;
using Xunit;

namespace OCR.SimultaniousLogin.EntityFrameworkCore.Applications;

[Collection(SimultaniousLoginTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SimultaniousLoginEntityFrameworkCoreTestModule>
{

}
