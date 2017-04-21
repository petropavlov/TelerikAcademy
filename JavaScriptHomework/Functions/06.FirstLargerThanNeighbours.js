/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

  let array = input[1].split(' ');
  let index = -1;

  for (let i = 1; i < array.length - 1; i++) {
    if (+array[i] > +array[i - 1] && +array[i] > +array[i + 1]) {
      index = i;
      break;
    }
  }
  console.log(index);
}
solve(['6', '-26 -25 -28 31 2 27']);
