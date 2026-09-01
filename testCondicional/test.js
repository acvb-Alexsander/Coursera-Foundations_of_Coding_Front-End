let pessoas = [16, 19, 20, 25, 9, 12, 5, 10, 15, 16, 17, 45, 48, 5];
let crianca = 0;
let adolescente = 0;
let adulto = 0;

for (const element of pessoas) {
  if (element > 0 && element < 10) {
    crianca++;
  } else if (element > 10 && element < 18) {
    adolescente++;
  } else {
    adulto++;
  }
}
console.log(
  `No evento possui ${crianca} crianças, ${adolescente} adolescentes e ${adulto} adultos`,
);
