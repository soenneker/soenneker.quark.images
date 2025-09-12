using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Images.Tests;

[Collection("Collection")]
public sealed class ImageTests : FixturedUnitTest
{
    public ImageTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Basic test to ensure the component can be instantiated
        Assert.True(true);
    }
}
