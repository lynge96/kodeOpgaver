
// a) Hvor mange riskorn fik opfinderen?

double riskorn = Math.Pow(2, 64);

Console.WriteLine($"Opgave a\n{riskorn:E3} riskorn");
// Svar: 18,45 trillioner riskorn.


// b) Hvis vi antager at 10 riskorn fylder 1 kubikcentimeter. Hvor mange kubikcentimeter fyldte alle riskornene?

double arealCM2 = riskorn / 10;

Console.WriteLine($"Opgave b\n{arealCM2:E3} kubikcentimeter");
// Svar: 1,845 trillioner kubikcentimeter.


// c) Hvis 10 riskorn vejer 1 gram, hvor mange tons vejede alle riskornene som opfinderen fik?

double vægtTotal = (riskorn / 10) / 1000000;

Console.WriteLine($"Opgave c\n{vægtTotal:E3} tons");
// Svar: 1,845 billioner tons.


// d) En almindelig lastbil må laste cirka 14 tons. Hvor mange lastbiler skulle man bruge for at køre al hveden væk?

double maxLast = 14;
double antalLastbiler = vægtTotal / maxLast;

Console.WriteLine($"Opgave d\n{antalLastbiler:E3} lastbiler");
// Svar: 131 milliarder lastbiler


// e) En almindelig lastbil er 12 meter lang. Hvor lang er hele vogntoget, der kørte alle opfinderens riskorn væk?

double lastbilLængde = 12;
double vogntogLængde = antalLastbiler * lastbilLængde;

Console.WriteLine($"Opgave e\n{vogntogLængde:E3} meter lang vogntoglængde");
// Svar: 1,581 billioner meter


// f) Jordens omkreds er 40075 km, hvor mange gange rundt om jorden når vogntoget?

double jordOmkreds = 40075 * 1000;
double jordenRundt = vogntogLængde / jordOmkreds;

Console.WriteLine($"Opgave f\n{jordenRundt:N} gange rundt om jorden");
// Svar: 39.454,76 gange rundt om jorden


// g) Tror du opfinderen nogensinde fik alle hans riskorn?

Console.WriteLine("\nI doutbt it :)");