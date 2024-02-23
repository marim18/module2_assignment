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
    public class Temperatureconverter
    {
        public static double Fahrenheittocelcius(string fahrenheit)
        {
            double f = double.Parse(fahrenheit);
            double c = (5.0 / 9.0) * (f - 32);
            return Math.Round(c, 2);
        }
    }
    public static class wordcounter
    {
        public static string Getuni1uewords(string input)
        {
            string[] wordArray = input.Split(",");
            HashSet<string> uniqueWords = new HashSet<string>(wordArray);
            List<string> alphabetically = uniqueWords.ToList();
            alphabetically.Sort();
            string result = string.Join(",", alphabetically);
            return result;
        }
    }
    public static class series
    {
        public static int seriesnext(string input)
        {
            int[] inputArray = input.Split(",").Select(int.Parse).ToArray();
            int x = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if ((inputArray[i] - inputArray[i - 1]) != x)
                {
                  x++;
                }
            }
            int lastNumber = inputArray[inputArray.Length - 1];
            int nextNumber = lastNumber + x;
            return nextNumber;
        }
    }

}