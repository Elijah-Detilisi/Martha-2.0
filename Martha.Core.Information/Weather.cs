namespace Martha.Core.Information
{
    using System.Threading.Tasks;

    public class Weather
    {
        public async Task GetForecastAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/minutely?lat=35.5&lon=-78.5"),
                Headers =
                {
                    { "X-RapidAPI-Key", "fc0398a279mshb8a6b0a90a75aaep1199c7jsnec32f9339ee5" },
                    { "X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
