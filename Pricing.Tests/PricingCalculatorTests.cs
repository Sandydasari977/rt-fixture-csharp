using Fixture;
using Xunit;

public class PricingCalculatorTests
{
    [Fact]
    public void NoCouponKeepsTheSubtotal()
    {
        Assert.Equal(80m, PricingCalculator.DiscountedTotal(80m));
    }
}
