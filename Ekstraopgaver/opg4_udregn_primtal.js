console.log("initializing...");

// Returner true hvis n er et primtal, ellers false.
// Kan løses med et for loop og en if-sætning.
// Husk at du altid kan få rest ved division: https://javascript.info/operators#remainder
function erPrimtal(n) {
    for (let i = 2; i < n; i++)
        if(n % i === 0) return false;
    return n > 1;
}
console.log("erPrimtal (true)", erPrimtal(3));
console.log("erPrimtal (true)", erPrimtal(7));
console.log("erPrimtal (false)", erPrimtal(10));
console.log("erPrimtal (true)", erPrimtal(20123));
console.log("erPrimtal (false)", erPrimtal(112345670));
console.log("erPrimtal (true)", erPrimtal(2));

// Print alle primtal op til og med n.
// Brug den forrige funktion og et loop.
function udskrivPrimtal(n) {
    for (let i = 0; i <= n; i++) {
        if (erPrimtal(i) == true) {
            console.log(i);
        } 
    }
}
udskrivPrimtal(100);