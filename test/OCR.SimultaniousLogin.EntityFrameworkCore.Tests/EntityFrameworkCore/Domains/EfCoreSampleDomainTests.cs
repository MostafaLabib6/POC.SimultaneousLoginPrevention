using OCR.SimultaniousLogin.Samples;
using Xunit;

namespace OCR.SimultaniousLogin.EntityFrameworkCore.Domains;

[Collection(SimultaniousLoginTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SimultaniousLoginEntityFrameworkCoreTestModule>
{

}
