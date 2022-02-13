// Opgave 1 - Lav en simpel funktion
console.log("opgave1");

function sumTalrække(a, b) {
    // TODO: Skriv funktionens kode her
    let resultat = 0;
    for (i = a; i <= b; i++) {
        resultat = resultat + i;
    }
    return resultat;
  }
  console.log(sumTalrække(1,3)); // Skal udskrive 6
  console.log(sumTalrække(2,5)); // Skal udskrive 14
