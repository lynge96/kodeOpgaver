using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

// Brugeroplysninger
string password = "password123";

// Lav et 128-bit salt, som skal med i hash-funktionen når password hashes
byte[] saltBytes = new byte[128 / 8];
using (var rng = RandomNumberGenerator.Create())
{
    rng.GetNonZeroBytes(saltBytes);
}

// Her er den nye salt:
string salt = Convert.ToBase64String(saltBytes); 

// Lav en 256-bit hash af "password + salt" - og gør det 100.000 gange!
// HMACSHA256 er navnet på hash-funktionen der anvendes herunder
string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
    password: password,
    salt: Convert.FromBase64String(salt),
    prf: KeyDerivationPrf.HMACSHA256,
    iterationCount: 100000,
    numBytesRequested: 256 / 8));

Console.WriteLine($"Password {password} plus salt {salt} er hashed til {hashed}");
