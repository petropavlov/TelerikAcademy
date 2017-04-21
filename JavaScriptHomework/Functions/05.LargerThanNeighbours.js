/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

  let array = input[1].split(' ');
  let counter = 0;

  for (let i = 1; i < array.length - 1; i++) {
    if (+array[i] > +array[i - 1] && +array[i] > +array[i + 1]) {
      counter += 1;
    }
  }

  console.log(counter);
}
solve(['6', '-26 -25 -28 31 2 27']);
