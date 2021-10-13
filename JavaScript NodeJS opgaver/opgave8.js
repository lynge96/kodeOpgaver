let tekst = process.argv[2]; // Input til programmet
// console.log(tekst); // Printer input

console.log(tekst.length);
console.log(tekst.replace("kage", "rugbrød"));

if (tekst.length > 50) {
    console.log(tekst.substring(0,10));
}

if (tekst.includes("svin", "hundehovede", "skidespræller", "skiderik", "socialdemokrat") == true) {
    console.log("Forbudt");
}   else {
        console.log("Godkendt");
    }
