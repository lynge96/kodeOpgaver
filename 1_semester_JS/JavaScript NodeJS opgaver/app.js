// Opg 2.1
// for (let i = 5; i < 51; i++) {
//     console.log("Tallet er " + i);
// }

// Opg 2.2
// for (let i = 2; i < 40; i++) {
//     if (i % 2 === 0) {
//         console.log("Tallet er " + i);
//     }
// }

// Opg 2.3
// let sum = 0
// for (let i = 1; i < 100; i++) {
//     if (i % 2 !== 0) {
//         sum = sum + i;
//     }
// }
// console.log(sum);

// Opg 2.4
// for (let i = 80; i >= 40; i--) {
//     console.log(i);
// }

// Opg 2.5
// let sum = 0;
// for (let i = 0; i < 10; i++) {
//     if (i % 2 == 0) continue;
//         sum = sum + i;
//         console.log(sum);
// }

// Opg 3.1
// Descending
// for (let i = 0; i < 10; i++) {
//     let output = "";
//     for (let j = 0; j < i; j++) {
//       output = output + "*";
//     }
//     console.log(output);
//   }

// Ascending
// for (let i = 0; i < 10; i++) {
//     let output = "";
//     for (let j = 10; j > i; j--) {
//       output = output + "*";
//     }
//     console.log(output);
//   }

// Opg 5.1
let tekst = "Hej med dig";
console.log(tekst.length);
console.log(tekst.substring(4, 7));
console.log(tekst.substring(8, 11));
console.log(tekst.includes("med"));
console.log(tekst.includes("banankage"));
console.log(tekst.replace("dig", "banankage"));
console.log(tekst.replaceAll("e", "ø"));
