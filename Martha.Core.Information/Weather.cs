namespace Martha.Core.Information
{
    using System.Threading.Tasks;

    public static class Weather
    {
        public static async Task<string> GetForecastAsync(long coordX, long coordY)
        {
            var client = new HttpClient();
            var requestUri = $"https://weatherbit-v1-mashape.p.rapidapi.com/forecast/minutely?lat={coordX}&lon={coordY}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(requestUri),
                Headers =
                {
                    { "X-RapidAPI-Key", "fc0398a279mshb8a6b0a90a75aaep1199c7jsnec32f9339ee5" },
                    { "X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
    }
}
