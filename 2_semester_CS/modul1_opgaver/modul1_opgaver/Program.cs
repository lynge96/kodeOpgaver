using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace modul1_opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Udskriv resultatet af et plus-stykke

            int a = 12;
            int b = 30;

            int c = a + b;
            Console.WriteLine(c);

            // Udskriv resultatet af et minus-stykke
            int minusStykke = 34 - 23;
            Console.WriteLine(minusStykke);

            // Udskriv resultatet af et gange-stykke
            int gangeStykke = 3 * 23;
            Console.WriteLine(gangeStykke);

            // Udskriv resultatet af et divisions-stykke der går op 
            int ligeDivision = 50 / 2;
            Console.WriteLine(ligeDivision);

            // Udskriv resultatet af et divisions-stykke der ikke går op 
            int uligeDivison = 23 / 2;
            Console.WriteLine(uligeDivison);

            // Udskriv resultatet af dette divisionsstykke "rest" (kaldes modulo)
            int moduloDivision = 21 % 4;
            Console.WriteLine(moduloDivision);

            // Udskriv resultatet af følgende givne matematikopgaver: 
            int stykke1 = -1 + 4 * 6;
            Console.WriteLine(stykke1);
            try
            {
                Assert.AreEqual(stykke1, 26);
            }
            catch
            {
                Console.WriteLine("Kæmpe fejl lol xD");
            }

            int stykke2 = (35 + 5) % 7;
            Console.WriteLine(stykke2);

            float stykke3 = 14 + -4 * 6 / 11;
            Console.WriteLine(stykke3);

            float stykke4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(stykke4);

            // 1.04 Byt plads på to input.
            Console.WriteLine("Skriv første tal:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv andet tal:");
            int input2 = int.Parse(Console.ReadLine());
            // Omvendt rækkefølge:
            Console.WriteLine("input2: " + input2);
            Console.WriteLine("input1: " + input1);
            // 1.05 Matematik med bruger:
            Console.WriteLine("Matematik med 2 inputs:");
            Console.WriteLine("Addition: " + (input1 + input2)); // Addition
            Console.WriteLine("Subtraktion: " + (input1 - input2)); // Subtraktion
            Console.WriteLine("Gange: " + (input1 * input2)); // Gange
            Console.WriteLine("Division: " + (input1 / input2)); // Divison
            Console.WriteLine("Modulo " + (input1 % input2)); // Modulo

            // 1.06 Celsius til Kelvin og Fahrenheit
            Console.WriteLine("Indtast antal grader celsius");
            double graderCelsius = double.Parse(Console.ReadLine());

            // Konverterer celius til kelvin:
            double graderKelvin = graderCelsius + 273.15;
            Console.WriteLine(graderCelsius + " celsius til kelvin er: " + graderKelvin);

            // Konverterer celsius til fahrenheit:
            double graderFahrenheit = graderCelsius * 1.8 + 32;
            Console.WriteLine(graderCelsius + " celsius til fahrenheit er: " + graderFahrenheit);
        }
    }

}
