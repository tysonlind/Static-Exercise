using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelcius (double temp)
        {
            return (temp - 32) * 5/9;
        }
        public static double CelciusToFahrenheit (double temp)
        {
            return (temp * 9 / 5) + 32;
        }
    }
}
