/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = input.toString().split(''),
        decimalNumber = 0;

    for (let i = 0; i < array.length; i+= 1) {
        if (array[i] === 'A') {
            array[i] = '10';
        }
        if (array[i] === 'B') {
            array[i] = '11';
        }
        if (array[i] === 'C') {
            array[i] = '12';
        }
        if (array[i] === 'D') {
            array[i] = '13';
        }
        if (array[i] === 'E') {
            array[i] = '14';
        }
        if (array[i] === 'F') {
            array[i] = '15';
        }
    }

    array = array.reverse();

    for (let i = 0; i < array.length; i+= 1) {
        decimalNumber += array[i] * Math.pow(16, i);
    }
    console.log(decimalNumber);
}
solve(['4ED528CBB4']);
