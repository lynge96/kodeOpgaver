console.log("initializing...");

function kodestumpA() {
  // Kodestump A
  let sum = 0;
  for (let i = 1; i <= 10; i++) {
    sum = sum + i;
  }
  // Forventet svar: 55
  console.log(sum);
}
console.log(kodestumpA());

function kodestumpB() {
  // Kodestump B
  let sum = 0;
  for (let i = 3; i < 8; i++) {
    sum = sum + i;
  }
  // Forventet svar: 25
  console.log(sum);
}
console.log(kodestumpB());

function kodestumpC() {
  // Kodestump C
  let sum = 2;
  for (let i = 1; i <= 10; i++) {
    sum = i - sum;
  }
  // Forventet svar: 7
  console.log(sum);
}
console.log(kodestumpC());

function kodestumpD() {
  // Kodestump D
  let sum = 2;
  for (let i = 1; i <= 10; i = i * 3) {
    sum = sum * i;
  }
  // Forventet svar: 54
  console.log(sum);
}
console.log(kodestumpD());

function kodestumpE() {
  // Kodestump E
  let sum = 1;
  for (let i = 1; i <= 10; i = i * 2) {
    sum = sum * i;
  }
  // Forventet svar: 64
  console.log(sum);
}
console.log(kodestumpE());

function kodestumpF() {
  // Kodestump F
  let sum = 2;
  for (let i = 6; i > 1; i--) {
    sum = sum * i;
  }
  // Forventet svar: 1440
  console.log(sum);
}
console.log(kodestumpF());