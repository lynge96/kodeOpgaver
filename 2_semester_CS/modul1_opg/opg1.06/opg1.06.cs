using System;

// 1.06 Celsius til Kelvin og Fahrenheit
Console.WriteLine("Indtast antal grader celsius");
double graderCelsius = double.Parse(Console.ReadLine());

// Konverterer celius til kelvin:
double graderKelvin = graderCelsius + 273.15;
Console.WriteLine(graderCelsius + " celsius til kelvin er: " + graderKelvin);

// Konverterer celsius til fahrenheit:
double graderFahrenheit = graderCelsius * 1.8 + 32;
Console.WriteLine(graderCelsius + " celsius til fahrenheit er: " + graderFahrenheit);