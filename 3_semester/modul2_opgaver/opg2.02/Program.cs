Person[] people = new Person[]
{
    new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
    new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
    new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
    new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
    new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
    new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
};

// Find og udskriv personen med mobilnummer “+4543215687”.
var findTelefonnummer = people.Where(tlf => tlf.Phone == "+4543215687");
Console.WriteLine("Personen med +4543215687.");
Console.WriteLine(findTelefonnummer.First().Name);

// Vælg alle som er over 30 og udskriv dem.
var over30 = people.Where(alder => alder.Age > 30);
Console.WriteLine("\nPersoner over 30 år");
Console.WriteLine(string.Join(", ", over30));

// Lav et nyt array med de samme personer, men hvor “+45” er fjernet fra alle telefonnumre.
var arrayUden45 = people.Select(p => new Person { Name = p.Name, Age = p.Age, Phone = p.Phone.Substring(2) });
Console.WriteLine("\nTelefonnummer uden +45");
Console.WriteLine(string.Join(", ", arrayUden45));

// Generér en string med navn og telefonnummer på de personer, der er yngre end 30, adskilt med komma
var under30 = people.Where(p => p.Age < 30);
Console.WriteLine("\nPersoner under 30 år.");
Console.WriteLine(string.Join(", ", under30));

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }

    public override string ToString() { return Name + " " + Phone; }
}
