console.log("Opgave 1 :)");
function højesteTal(a, b, c) {
    if (a > b && a > c) {           // Tjekker om input A er størst.
        return a;                       // Returnerer A hvis det er.
    } else if (b > a && b > c) {    // Tjekker om input B er størst.
        return b;                       // Returnerer B hvis det er.
    } else return c;                // Ellers bliver C returneret. :)
}
// Inputs
console.log(højesteTal (1, 4, 6));
console.log(højesteTal (2, 1, 1));
console.log(højesteTal (9, 4, 6));
console.log(højesteTal (4, 99, 2));

console.log("Opgave 2 :)");
function minusTal(array) {
    let nytArray = [];                          // Tomt array til de nye værdier.
    for (let i = 0; i < array.length; i++) {    // For-loop der kører igennem arrayet.
        if (array[i] < 0) {                     // Tjekker om indeks i på arrayet er et minustal.
            nytArray.push(array[i])             // Hvis ja, pusher det ind i det tomme array.
        }
    }
    return nytArray                             // Returnerer nytArray med alle minus tal i. :)
}
// Input
console.log(minusTal([-1, 1, 4, -1, -9, -3, 8, 9, -3, 0, -7]));

console.log("Opgave 3 :)");
function tjekAlder(alder) {
    if (alder >= 18) {                          // Tjekker om alder er 18 eller over.
        return true;                                // Hvis ja, returnerer true.
    } else if (alder < 18 && alder >= 16) {     // Tjekker om alder er over 16 og under 18.
        return "bajer";                             // Hvis ja, returnerer bajer.
    } else return false;                        // Ellers er alderen under 16, og returnerer false.
}
// Inputs
console.log(tjekAlder(9));
console.log(tjekAlder(-1));
console.log(tjekAlder(17));
console.log(tjekAlder(80));

console.log("Opgave 4 :)");
function forskel(a, b, c) {
    let størst = Math.max(a, b, c);     // Finder det største tal fra inputs.
    let mindst = Math.min(a, b, c);     // Finder det mindste tal fra inputs.
    return størst - mindst              // Finder differencen på størst og mindst.
}
// Inputs
console.log(forskel(9, 10, 50));
console.log(forskel(3, 42, 8));
console.log(forskel(99, 0, 50));
console.log(forskel(80, 80, 80));