/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

  let array = input[1].split(' '),
    newArray = [],
    checkArray = input[1].split(' ');

  for (let i = 0; i < input[0]; i++) {
    newArray.push(maxNumber());
  }

  function maxNumber(x) {

    for (let i = 0; i < input[0]; i++) {
      let number = checkArray[0];

      for (let j in checkArray) {
        if (+number < +checkArray[j]) {
          number = checkArray[j];
        }
      }

      for (let j in checkArray) {
        if (+number === +checkArray[j]) {
          checkArray.splice(j, 1);
          break;
        }
      }
      return number;
    }
  }
  console.log(newArray.reverse().join(" "));
}
solve(['10', '36 10 1 34 28 38 31 27 30 20']);
