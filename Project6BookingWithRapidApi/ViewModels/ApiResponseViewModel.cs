namespace Project6BookingWithRapidApi.ViewModels
{
    public class ApiResponseViewModel
    {
        public List<PropertyViewModel> Data { get; set; } = new List<PropertyViewModel>();
        public MetaViewModel Meta { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }

}
