namespace Fixture;

public static class PricingCalculator
{
    /// <summary>Total after a coupon: SAVE10 takes 10% off orders of 50 or more.</summary>
    public static decimal DiscountedTotal(decimal subtotal, string? coupon = null)
    {
        if (coupon == "SAVE10" && subtotal >= 50)
        {
            return decimal.Round(subtotal * 0.9m, 2);
        }
        return subtotal;
    }
}
