// Opgave 6 - Lav array-funktioner
// Lav følgende funktioner:

// En funktion der tager et array af tal som input. Funktionen skal returnerer summen af alle tal.
console.log("opgave6.1");

let array = [1, 6, 2, 5, 7, 8];

function arraySum(array) {
    let sum = 0;
    for (let i = 0; i < array.length; i++) {
        sum += array[i];
    }
    return sum;
}
console.log(arraySum(array));

// En funktion der tager et array med tekst som input. Funktionen skal returnerer summen af længderne på alle tekster i arrayet.
console.log("opgave6.2");

let arrayTekst = ["computer", "skærm", "mus", "keyboard", "kaffekop"];

function tekstSum(arrayTekst) {
    let tSum = 0;
    for (let i = 0; i < arrayTekst.length; i++) {
        tSum += arrayTekst[i].length;
    }
    return tSum;
}
console.log(tekstSum(arrayTekst));

// En funktion der tager to arrays, og returnerer et nyt langt array hvor elementer fra de to arrays er sat sammen. Fx bliver [1, 2, 3] og [4, 5, 6] til [1, 2, 3, 4, 5, 6].
console.log("opgave6.3");

let arrayA = [1, 2, 3];
let arrayB = [4, 5, 6];

function arraySammen(arrayA, arrayB) {
    let arrayTillæg = arrayA.concat(arrayB);
    return arrayTillæg;
}
console.log(arraySammen(arrayA, arrayB));

// En funktion der tager to arrays med samme længde, og hvor begge indeholder tal. Funktionen skal returnerer et nyt array hvor tallene er lagt parvis sammen. Fx hvis du har [1, 2, 3] og [4, 5, 6], så giver det [5, 7, 9] når de er lagt sammen.
console.log("opgave6.4");

let a = [1, 2, 3];
let b = [4, 5, 6];

function arrayPlus(a, b) {
    let result = [];
    for (let i = 0; i < a.length; i++) {
        result.push(a[i] + b[i]);
    }
    return result;
}
console.log(arrayPlus(a, b));

// En funktion der tager et array med tekst som input. Funktionen skal returnere den længste tekst i arrayet.
console.log("opgave6.5");

let d = ["computer", "skærm", "mus", "keyboard", "kaffekop"];

function længsteOrd() {
    let result = [];

    return result;
}
console.log(længsteOrd());