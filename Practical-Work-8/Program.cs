using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Practical_Work_8
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            try
            {
                string weatherPath = "weather.json";
                List<DefaultCity> defaultCityList;

                if (File.Exists(weatherPath))
                {
                    string weatherJson = File.ReadAllText(weatherPath);
                    defaultCityList = JsonConvert.DeserializeObject<List<DefaultCity>>(weatherJson);
                }
                else
                {
                    defaultCityList = new List<DefaultCity>();
                }
                
                ViewDefaultCityWeather(defaultCityList);

                while (true)
                {
                    Thread.Sleep(1500);
                    
                    Console.WriteLine("Выберите действие.");
                    Console.WriteLine("1. Погода в городе.");
                    Console.WriteLine("2. Задать город по умолчанию.");
                    Console.WriteLine("3. Удалить город по умолчанию.");
                    Console.WriteLine("4. Выйти из программы.");

                    int choice = GetChoice();

                    switch (choice)
                    {
                        case 1:
                        {
                            CityWeather();
                            break;
                        }
                        case 2:
                        {
                            SetDefaultCityWeather(defaultCityList);
                            break;
                        }
                        case 3:
                        {
                            RemoveDefaultCityWeather(defaultCityList);
                            break;
                        }
                        case 4:
                        {
                            string weatherJson = JsonConvert.SerializeObject(defaultCityList);
                            File.WriteAllText(weatherPath, weatherJson);
                            return;
                        }
                        default:
                        {
                            Console.WriteLine("Некорректный выбор. Попробуйте снова.\n");
                            break;
                        }
                    }
                    Thread.Sleep(1500);
                }
                
                static int GetChoice()
                {
                    while (true)
                    {
                        Console.Write("Действие: ");

                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            return choice;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                        }
                    }
                }

                static async Task CityWeather()
                {
                    Console.WriteLine("\nВведите название города:");
                    string city = Console.ReadLine();
                    
                    string apiKey = "8f0f93c71d748997cc904ac27419799f";
                    string apiResponse = await GetWeather(city, apiKey);

                    dynamic weatherData = JsonConvert.DeserializeObject(apiResponse);
            
                    string description = weatherData.weather[0].description;
                    double temp = weatherData.main.temp - 273.15;
                    
                    Console.WriteLine($"Погода в городе {city}: {description}. Температура: {temp}°C.\n");
                }

                static void SetDefaultCityWeather(List<DefaultCity> defaultCityList)
                {
                    Console.WriteLine("\nВведите название города по умолчанию:");
                    string city = Console.ReadLine();

                    DefaultCity item = new DefaultCity
                    {
                        City = city
                    };
                    
                    for (int i = 0; i < defaultCityList.Count; i++)
                    {
                        defaultCityList.RemoveAt(i);
                    }
                    
                    defaultCityList.Add(item);
                    Console.WriteLine("Город по умолчанию установлен.\n");
                }

                static void RemoveDefaultCityWeather(List<DefaultCity> defaultCityList)
                {
                    defaultCityList.Clear();
                    Console.WriteLine("Город по умолчанию удалён.\n");
                }

                static async Task ViewDefaultCityWeather(List<DefaultCity> defaultCityList)
                {
                    if (defaultCityList.Count > 0)
                    {
                        DefaultCity item = defaultCityList[0];
                        string city = item.City;

                        string apiKey = "8f0f93c71d748997cc904ac27419799f";
                        string apiResponse = await GetWeather(city, apiKey);

                        dynamic weatherData = JsonConvert.DeserializeObject(apiResponse);

                        string description = weatherData.weather[0].description;
                        double temp = weatherData.main.temp - 273.15;

                        Console.WriteLine("Погода в городе по умолчанию:");
                        Console.WriteLine($"{city}: {description}. Температура: {temp}°C.\n");
                    }
                    else
                    {
                        Console.WriteLine("Нет заданного города по умолчанию.\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async Task<string> GetWeather(string city, string apiKey)
        {
            string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            else
            {
                throw new Exception($"Ошибка при получении данных о погоде: {response.StatusCode}");
            }
        }
    }

    class DefaultCity
    {
        public string City { get; set; }
    }
}
