// Opgave 5 - En funktion der vender et array om
// Her et et eksempel på en funktion der kopiere alle elementer fra et array over i et nyt array.

// Returnerer en kopi af et array
function copyArray(array) {
    let nytArray = []; // Det nye array er tomt
    // Vi looper over alle gamle elementer
    for (let i = 0; i < array.length; i++) {
      // Indsæt et gammelt element i det nye array
      nytArray.push(array[i]);
    }
    return nytArray; // Returner det nye array
  }

// Med inspiration fra eksemplet, lav en ny funktion vendOm(array), der laver et nyt array med alle de gamle elementer, men med omvendt rækkefølge.
console.log("vendOmArray");

let array1 = [1, 2, 3, 4];

function vendOm(array1) {
    let array2 = [];
    for (let i = array1.length - 1; i >= 0; i--) {
        array2.push(array1[i]);
    }
    return array2;
}
console.log(vendOm(array1));