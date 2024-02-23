using System.Collections.Generic;

namespace everywhere
{
    public class RomanConverter
    {
        private static readonly Dictionary<char, int> romanVariables = new Dictionary<char, int>()
        {
            { 'I', 1},
            { 'V', 5},
            { 'X', 10},
            { 'L', 50},
            { 'C', 100}
        };

        public static int Romannumeral(string input)
        {
            int num1 = 0;
            int prevValue = 0;

            foreach (char c in input)
            {
                int value = romanVariables[c];
                num1 += value;
                if (prevValue < value)
                {
                    num1 -= 2 * prevValue;
                }
                prevValue = value;
            }

            return num1;
        }
    }
    public class Temperatureconverter{
        public static double Fahrenheittocelcius(string fahrenheit){
            double f =  double.Parse(fahrenheit);
            double c = (5.0 / 9.0) * (f - 32);
            return Math.Round(c, 2);
        }
    }
}