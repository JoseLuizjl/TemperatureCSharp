using System;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### TEMPERATURE CONVERTER ###\n");

            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.WriteLine("3 - Kelvin\n");

            Console.Write("Choose an option (1, 2, or 3): ");
            string userInput = Console.ReadLine();

            double degrees;

            if (int.TryParse(userInput, out int temperature))
            {
                switch (temperature)
                {
                    case 1:
                        Console.WriteLine("\nYou chose Celsius");
                        Console.Write("How many degrees? ");
                        if (double.TryParse(Console.ReadLine(), out degrees))
                        {
                            double fahrenheitResult = (degrees * 1.8) + 32;
                            Console.WriteLine($"\n{degrees} °C to Fahrenheit is {fahrenheitResult:F2}");

                            double kelvinResultCelsius = degrees + 273.15;
                            Console.WriteLine($"{degrees} °C to Kelvin is {kelvinResultCelsius:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Celsius degrees.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nYou chose Fahrenheit");
                        Console.Write("How many degrees? ");
                        if (double.TryParse(Console.ReadLine(), out degrees))
                        {
                            double celsiusResultCase2 = (degrees - 32) * 0.55556;
                            Console.WriteLine($"\n{degrees} °F to Celsius is {celsiusResultCase2:F2}");

                            double kelvinResultFahrenheit = (degrees - 32) * 0.55556 + 273.15;
                            Console.WriteLine($"{degrees} °F to Kelvin is {kelvinResultFahrenheit:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Fahrenheit degrees.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nYou chose Kelvin");
                        Console.Write("How many degrees? ");
                        if (double.TryParse(Console.ReadLine(), out degrees))
                        {
                            double celsiusResultCase3 = degrees - 273.15;
                            Console.WriteLine($"\n{degrees} °K to Celsius is {celsiusResultCase3:F2}");

                            double fahrenheitResultKelvin = (degrees - 273.15) * 1.8 + 32;
                            Console.WriteLine($"{degrees} °K to Fahrenheit is {fahrenheitResultKelvin:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Kelvin degrees.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Choose 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Choose 1, 2, or 3.");
            }
        }
    }
}
