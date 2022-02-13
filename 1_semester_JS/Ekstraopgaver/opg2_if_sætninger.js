console.log("initializing...");

console.log("Første function:");
// Skal returnerer true hvis tallene er ens, ellers false
function erEns(a, b, c) {
  if (a == b && a == c) {
    return true;
  } else return false;
}
console.log("erEns (false)", erEns(1, 2, 3));
console.log("erEns (true)", erEns(3, 3, 3));

console.log("Anden function:");
// Skal returnere true hvis hvert tal er større end det foregående.
// Dvs. a < b < c. Ellers returneres false.
function erStigende(a, b, c) {
  if (a < b && b < c) {
    return true;
  } else return false;
}
console.log("erStigende (true)", erStigende(1, 2, 3));
console.log("erStigende (false)", erStigende(1, 3, 2));

console.log("Tredje function:");
// En funktion der returnerer true hvis tallene er sorteret
// enten i stigende eller faldende orden. Ellers false.
// Fx er "3,2,1" true, "1,2,3" er også true, men "1,3,2" er false.
function erSorteret(a, b, c) {
  if (a < b && b < c) {
    return true;
  } else if (a > b && b > c) {
    return true;
  } else return false;
}
console.log("erSorteret (true)", erSorteret(1, 2, 3));
console.log("erSorteret (false)", erSorteret(3, 2, 3));
console.log("erSorteret (true)", erSorteret(3, 2, 1));

console.log("Fjerde function:");
// Returnerer true hvis forskellen imellem de to tal er mindre end 10,
// ellers false.
function erTætPåHinanden(a, b) {
    if (b - a < 10 && a - b < 10) {
        return true;
    } else return false;
}
console.log("erTætPåHinanden (true)", erTætPåHinanden(1, 5));
console.log("erTætPåHinanden (false)", erTætPåHinanden(5, 25));
console.log("erTætPåHinanden (false)", erTætPåHinanden(15, 2));