using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        Random rnd = new Random();
        public int temperature;
        public int conditionsRoll;
        public string dailyWeatherCondition;
        
        public string RollConditions()
        {
            WeatherConditionsRoll();
            NameWeatherConditions();
            return dailyWeatherCondition;
        }
        public int TemperatureRoll()
        {
            temperature = rnd.Next(40, 100);
            return temperature;
        }

        public int WeatherConditionsRoll()
        {
            conditionsRoll = rnd.Next(-2, 3);
            return conditionsRoll;

        }

        public string NameWeatherConditions()
        {
            if (conditionsRoll == -2)
            {
                dailyWeatherCondition = "Snow";
                return dailyWeatherCondition;
            }
            else if (conditionsRoll == -1)
            {
                dailyWeatherCondition = "Rain";
                return dailyWeatherCondition;
            }
            else if (conditionsRoll == 0)
            {
                dailyWeatherCondition = "Fog";
                return dailyWeatherCondition;
            }
            else if (conditionsRoll == 1)
            {
                dailyWeatherCondition = "Hazy";
                return dailyWeatherCondition;
            }
            else if (conditionsRoll == 2)
            {
                dailyWeatherCondition = "Sunny";
                return dailyWeatherCondition;
            }
            else
            {
                dailyWeatherCondition = "Humid";
                return dailyWeatherCondition;
            }

        } 



    }
}
