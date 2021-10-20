// Opgave 3 - Funktionen skudår
// Du skal lave funktionen skudår(). Den ser cirka sådan her ud:

// årstal - Det årstal du gerne vil tjekke.
// Return value: _true_ hvis årstallet er skudår, og ellers _false_.
function skudår(årstal) {
    // TODO: Lav funktionen færdig
    if (årstal % 4 == 0) { // Bruger modulus / % til at finde alle år der er deleligt med 4, så de værdier returnerer true.
        return true;
    } else return false;
  }
console.log(skudår(2020));
