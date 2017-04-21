/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

  let array = input[1].split(" ");
  let counter = 0;

  for (let i in array) {
    if (+input[2] === +array[i]) {
      counter += 1;
    }
  }
  console.log(counter);
}
solve(['8', '28 6 21 6 -7856 73 73 -56', '73']);
