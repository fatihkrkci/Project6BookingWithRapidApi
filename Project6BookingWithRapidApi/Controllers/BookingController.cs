using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Project6BookingWithRapidApi.ViewModels;

public class BookingController : Controller
{
    private const string ApiKey = "552af13d75mshef9f1cc500ec243p176c29jsn8a925bef75a1";
    private const string ApiHost = "booking-com18.p.rapidapi.com";

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Search(string query, string checkinDate, string checkoutDate, int adults, int children)
    {
        var locationId = await GetLocationId(query);
        if (locationId == null)
        {
            return View("Error", "Şehir adı bulunamadı.");
        }

        var hotels = await GetHotels(locationId, checkinDate, checkoutDate, adults, children);
        return View("Results", hotels);
    }

    private async Task<string> GetLocationId(string query)
    {
        using var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://{ApiHost}/stays/auto-complete?query={query}"),
            Headers =
            {
                { "x-rapidapi-key", ApiKey },
                { "x-rapidapi-host", ApiHost },
            },
        };

        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<dynamic>(body);

        // İlk sonucu alıyoruz.
        return data?.data[0]?.id;
    }

    private async Task<List<HotelViewModel>> GetHotels(string locationId, string checkinDate, string checkoutDate, int adults, int children)
    {
        // Tarih formatını düzenle
        if (!DateTime.TryParse(checkinDate, out DateTime checkinDateParsed) ||
            !DateTime.TryParse(checkoutDate, out DateTime checkoutDateParsed))
        {
            throw new ArgumentException("Check-in veya check-out tarihi geçerli bir formatta değil.");
        }

        // API'ye uygun formatta tarihler
        string formattedCheckinDate = checkinDateParsed.ToString("yyyy-MM-dd");
        string formattedCheckoutDate = checkoutDateParsed.ToString("yyyy-MM-dd");

        using var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://{ApiHost}/stays/search?locationId={locationId}&checkinDate={formattedCheckinDate}&checkoutDate={formattedCheckoutDate}&adults={adults}&children={children}&units=metric&temperature=c"),
            Headers =
        {
            { "x-rapidapi-key", ApiKey },
            { "x-rapidapi-host", ApiHost },
        },
        };

        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<dynamic>(body);

        var hotels = new List<HotelViewModel>();
        foreach (var item in data?.data)
        {
            hotels.Add(new HotelViewModel
            {
                Id = item.id,
                Name = item.name,
                PhotoUrl = item.photoUrls[0],
                ReviewScoreWord = item.reviewScoreWord,
                ReviewScore = item.reviewScore,
                ReviewCount = item.reviewCount
            });
        }

        return hotels;
    }

}
