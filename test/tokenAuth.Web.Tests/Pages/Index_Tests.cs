using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace tokenAuth.Pages;

public class Index_Tests : tokenAuthWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
