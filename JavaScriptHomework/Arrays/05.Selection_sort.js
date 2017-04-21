/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = input,
  //  i = 0,
  //j = 0,
        numberToCheck = 0,
        number = Number.MAX_SAFE_INTEGER;

    array.shift();
    //console.log(array);
    while (numberToCheck < array.length) {

    for (let i = numberToCheck ; i < array.length; i++) {
        if (+array[i] > +array[i + 1]) {
            number = +array[i + 1];
        } 

    }
    //console.log(numberToCheck);
    for (let j = numberToCheck ; j < array.length; j++) {
        if (number === +array[j]) {
            array.splice(j, 1);
            array.unshift(number);
            console.log(array);
        }
    }
//  i++;
//   j++;
    numberToCheck++;
      }
    console.log(array);

}
solve(['6', '3', '7', '1', '5', '2', '6']);
