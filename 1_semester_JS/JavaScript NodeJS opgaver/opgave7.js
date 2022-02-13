let tekst = process.argv[2]; // Input til programmet
console.log(tekst); // Printer input

console.log(tekst.length);
if (tekst.includes("banankage")) {
    console.log("Det er lækkert!");
} else if (tekst.length > 50) {
    console.log("Det var en lang tekst");
} else if (tekst.length < 10) {
    console.log("Det var en kort tekst");
} else {
    console.log("ok");
}
