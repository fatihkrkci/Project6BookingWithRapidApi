namespace Project6BookingWithRapidApi.ViewModels
{
    public class PropertyViewModel
    {
        public CheckinViewModel Checkin { get; set; }
        public CheckoutViewModel Checkout { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string CheckinDate { get; set; }
        public string CheckoutDate { get; set; }
        public List<string> PhotoUrls { get; set; } = new List<string>();
        public int ReviewCount { get; set; }
        public int OptOutFromGalleryChanges { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int QualityClass { get; set; }
        public PriceBreakdownViewModel PriceBreakdown { get; set; }
        public string ReviewScoreWord { get; set; }
        public int Ufi { get; set; }
        public string Currency { get; set; }
        public bool IsFirstPage { get; set; }
        public string CountryCode { get; set; }
        public double ReviewScore { get; set; }
        public int AccuratePropertyClass { get; set; }
        public List<string> BlockIds { get; set; } = new List<string>();
        public int RankingPosition { get; set; }
        public string WishlistName { get; set; }
        public long MainPhotoId { get; set; }
        public int PropertyClass { get; set; }
        public int Position { get; set; }
        public bool IsPreferred { get; set; }
    }
}
