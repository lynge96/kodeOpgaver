// Opgave 2 - Lav nogle flere funktioner
/*
En funktion der tager tre tal som input. 
Funktionen skal returnerer true hvis alle tallene til sammen er over 100, ellers false.
*/
console.log("opgave2.1");

function treInputSum(a, b, c) {
    if (a + b + c >= 100) {
        return true;
    } else return false;
}
console.log(treInputSum(50, 12, 45));

/*
En funktion der tager en tekst som input, 
og returnerer teksten “Hejsa, navn”, hvor navn er lig med input.
*/
console.log("opgave2.2");

function tekstInd(navn) {
    return(`Hejsa ${navn}, velkommen!`);
}
console.log(tekstInd("Anders"));

/*
En funktion der tager to stykker tekst, og returnerer deres to forbogstaver sat sammen. Fx hvis input er “kat” og “hund”, skal return value være “kh”.
*/
console.log("opgave2.3");

function tekstSammensæt(ord1, ord2) {
    return (ord1.charAt(0) + ord2.charAt(0)); // charAt(index) - finder bogstavet på index-værdiens plads, og returnerer det.
}
console.log(tekstSammensæt("kat", "hund"));

/*
En funktion der tager to input: et tal og en tekst. Funktionen skal afgøre om teksten er længere end tallet, og returnerer true eller false.
*/
console.log("opgave2.4");

function toInput(tal, tekst) {
    if (tekst.length > tal) {
        return true;
    } else return false;
}
console.log(toInput(6, "flødebolle"));