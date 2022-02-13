// Opgave 4 - Lav et simpelt array
// Lav et simpelt array i JavaScript med tekst (navne på frugter). Gør som følger:

/*
Lav et array, kald det for “frugter”. Sørg for at det starter med følgende indhold (som tekst): “banan”, “pære”, “æble”, “appelsin”, “vindrue”.
*/
console.log("opgave4.1");

let frugter = ["banan", "pære", "æble", "appelsin", "vindrue"];
console.log(frugter);

/*
Udskriv nu det tredje element i arrayet med console.log via indeksering. Det skulle gerne vise sig at være “æble”.
*/
console.log("opgave4.2");

console.log(frugter[2]);

/*
Erstat det tredje element med en ny frugt.
*/
console.log("opgave4.3");

frugter[2] = "nektarin";
console.log(frugter[2]);

/*
Udskriv nu det samlede array i konsollen.
*/
console.log("opgave4.4");

console.log(frugter);

/*
Lav et loop der erstatter alle frugter i arrayet med “banankage”.
*/
console.log("opgave4.5");

for (let i = 0; i < frugter.length; i++) {
    frugter[i] = "banankage";
}

/*
Udskriv det samlede array igen.
*/
console.log("opgave4.6");

console.log(frugter);

/*
Brug et loop til at tilføje 50 “rugbrød” til arrayet, uden at ændre på det eksisterende indhold.
*/
console.log("opgave4.7");

for (let i = 0; i < 50; i++) {
    frugter.push("Rugbrød");
}
console.log(frugter);

