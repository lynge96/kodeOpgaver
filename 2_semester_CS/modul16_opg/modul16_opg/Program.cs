using opg16._02;

// Objekt af Person
Person Anders = new("Anders", "Trepkasgade 25, 5 th.");
// Objekt af Mekaniker
Mekaniker Denis = new("Denis", "Gratisluftvej 69", 2008, 165);
// Objekt af Værkfører
Værkfører Jacob = new("Jacob","Hvidvej 12", 2015, 154, 2020, 650);
// Objekt af Synsmand
Synsmand Abi = new("Abi", "Vibyhoodvej 30", 2018, 145, 45);

// Opretter liste af Person
List<Person> people = new List<Person>();
people.Add(Anders);
people.Add(Denis);
people.Add(Jacob);
people.Add(Abi);

foreach (Person p in people)
{
    Console.WriteLine($"{p.ToString()}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{p.Navn} tjener: {p.BeregnUgeLøn().ToString("C")} pr. uge\n");
    Console.ResetColor();
}