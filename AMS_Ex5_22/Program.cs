using System;

namespace AMS_Ex5_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 86;
            double grausCelsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("");
            Console.WriteLine("    ***CONVERSÃO DE FAHRENHEIT PARA GRAUS CELSIUS***      ");

            Console.WriteLine($"O valor equivalente a {fahrenheit} graus fahrenheit em graus Celsius é {grausCelsius}");
            Console.WriteLine("");

        }
    }
}
