using Newtonsoft.Json;
using System.Net.Http;

namespace Practical_Work_8
{
    class Program
    {
        static readonly HttpClient Client = new HttpClient();

        static async Task Main(string?[] args)
        {
            string? city;
            DefaultCity? defaultCity;

            if (File.Exists("default_city.json"))
            {
                string json = File.ReadAllText("default_city.json");
                defaultCity = JsonConvert.DeserializeObject<DefaultCity>(json);
            }
            else
            {
                defaultCity = new DefaultCity();
            }

            if (args.Length > 0)
            {
                if (args[0] == "SETDEFAULTCITY")
                {
                    Console.Write("Введите название города: ");
                    defaultCity!.City = Console.ReadLine();
                    string json = JsonConvert.SerializeObject(defaultCity);
                    File.WriteAllText("default_city.json", json);
                    return;
                }
                else if (args[0] == "REMOVEDEFAULTCITY")
                {
                    defaultCity!.City = null;
                    string json = JsonConvert.SerializeObject(defaultCity);
                    File.WriteAllText("default_city.json", json);
                    return;
                }
                else
                {
                    city = args[0];
                }
            }
            else
            {
                city = defaultCity!.City;
            }

            string apiKey = "8f0f93c71d748997cc904ac27419799f";
            string apiResponse = await GetWeather(city, apiKey);

            dynamic weatherData = JsonConvert.DeserializeObject(apiResponse)!;

            string description = weatherData.weather[0].description;
            double temp = weatherData.main.temp - 273.15;

            Console.WriteLine($"Погода в городе {city}: {description}. Температура: {Math.Round(temp)}°C.");
        }

        static async Task<string> GetWeather(string? city, string apiKey)
        {
            try
            {
                string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

                HttpResponseMessage response = await Client.GetAsync(requestUrl);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при получении данных о погоде: {e.Message}");
                throw;
            }
        }
    }
    
    class DefaultCity
    {
        public string? City { get; set; }
    }
}