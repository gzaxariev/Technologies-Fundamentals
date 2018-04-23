using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";

            string input = Console.ReadLine();

            Dictionary<string, Weather> forecast = new Dictionary<string, Weather>();

            while (!input.Equals("end"))
            {

                var match = Regex.Match(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    string cityName = match.Groups[1].ToString();
                    double averageTemp = double.Parse(match.Groups[2].ToString());
                    string weatherType = match.Groups[3].ToString();

                    Weather weather = new Weather(averageTemp, weatherType);

                    forecast[cityName] = weather;
                }

                input = Console.ReadLine();
            }

            foreach (var weather in forecast.OrderBy(w => w.Value.AverageTemperatura))
            {
                Console.WriteLine($"{weather.Key} => {weather.Value.AverageTemperatura:F2} => {weather.Value.WeatherType}");
            }
        }
    }

    public class Weather
    {
        public double AverageTemperatura { get; set; }
        public string WeatherType { get; set; }

        public Weather(double averageTemperatura, string weatherType)
        {
            AverageTemperatura = averageTemperatura;
            WeatherType = weatherType;
        }
    }
}
