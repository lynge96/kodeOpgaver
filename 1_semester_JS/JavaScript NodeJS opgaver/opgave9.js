console.log("initializing:");
// parseInt har til formål at lave en tekst om til et heltal
let tal1 = parseInt(process.argv[2]); // Input tal 1
let tal2 = parseInt(process.argv[3]); // Input tal 2
console.log(tal1, tal2); // Udskriver begge input-tal

// 1. Et program der printer enten “Input 1 er størst” eller “Input 2 er størst”.
if (tal1 > tal2) {
    console.log("Input 1 er størst");
} else if (tal1 < tal2) {
    console.log("Input 2 er størst");
}

// 2. Et program der udskriver summen af de to input-tal.
let sum = tal1+tal2;
console.log("Summen er " + sum);

// 3. Et program der via et loop udskriver alle tal fra input 1 til input 2.
for (let i = 2; i < 4; i++) {
    console.log(process.argv[i]);
}

if (tal1 < tal2) {
    for (let i = tal1; i <= tal2; i++) {
        console.log(i);
    }
} else {
    for (let i = tal1; i >= tal2; i--) {
        console.log(i);
    }
}
console.log("Opgave4");
// 4. Et program der udskriver 5 tal, startende med input 1, men hvor intervallet imellem tallene er lig med tal 2. Fx giver node app.js 0 5 outputtet 0 5 10 15 20.
for (let i = 0; i < 5; i++) {
    console.log(tal1 + tal2 * i);
}