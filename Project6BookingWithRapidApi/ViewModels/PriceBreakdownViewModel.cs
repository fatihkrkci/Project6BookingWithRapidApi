namespace Project6BookingWithRapidApi.ViewModels
{
    public class PriceBreakdownViewModel
    {
        public ExcludedPriceViewModel ExcludedPrice { get; set; }
        public StrikethroughPriceViewModel StrikethroughPrice { get; set; }
        public List<object> TaxExceptions { get; set; } = new List<object>();
        public GrossPriceViewModel GrossPrice { get; set; }
        public List<BenefitBadgeViewModel> BenefitBadges { get; set; } = new List<BenefitBadgeViewModel>();
    }

}
