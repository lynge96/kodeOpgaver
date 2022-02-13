console.log("initializing...");

function kodestumpA() {
  // Kodestump A
  let n = 1;
  let k = 2;
  let r = n;
  if (k < n) {
    r = k;
  }
  //Forventet svar: n = 1, k = 2, r = 1
  console.log(`n = ${n}, k = ${k}, r = ${r}`);
}
console.log(kodestumpA());

function kodestumpB() {
  // Kodestump B
  let n = 1;
  let k = 2;
  let r;
  if (n < k) {
    r = k;
  } else {
    r = k + n;
  }
  // Forventet svar: n = 1, k = 2, r = k = 2
  console.log(`n = ${n}, k = ${k}, r = ${r}`);
}
console.log(kodestumpB());

function kodestumpC() {
  // Kodestump C
  let n = 1;
  let k = 2;
  let r = k;
  if (r < k) {
    n = r;
  } else {
    k = n;
  }
  // Forventet svar: n = 1; k = n = 1, r = 2
  console.log(`n = ${n}, k = ${k}, r = ${r}`);
}
console.log(kodestumpC());

function kodestumpD() {
  // Kodestump D
  let n = 1;
  let k = 2;
  let r = 3;
  if (r < n + k) {
    r = 2 * n;
  } else {
    k = 2 * r;
  }
  // Forventet svar: n = 1, k = 6, r = 3
  console.log(`n = ${n}, k = ${k}, r = ${r}`);
}
console.log(kodestumpD());