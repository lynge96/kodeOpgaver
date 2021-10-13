// Opgave 10 - Et terningespil

// Noget JavaScript der gør det muligt at læse fra terminalen når der skrives.
const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
  })
  
  // Noget JavaScript der læser et svar på et spørgsmål fra terminalen.
  readline.question(`Hvad bliver næste terningekast? `, function(gæt) {
    console.log(`Du gætter på ${gæt}!`);
  
    // Kast terning: 
    let terning = Math.floor(Math.random() * 6 + 1);
    console.log(`Der blev kastet ${terning}!`);
  
    // TODO: Udskriv om spilleren gættede rigtigt eller forkert!
    if (gæt == terning) {
        console.log("True dude!!1!1");
    } else {
        console.log("Unlucky :i");
    }
    readline.close();
  })
  
  