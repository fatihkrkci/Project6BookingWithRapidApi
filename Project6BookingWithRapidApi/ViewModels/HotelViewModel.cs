namespace Project6BookingWithRapidApi.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; } // İlk eleman
        public string ReviewScoreWord { get; set; }
        public double ReviewScore { get; set; }
        public int ReviewCount { get; set; }
    }

}
