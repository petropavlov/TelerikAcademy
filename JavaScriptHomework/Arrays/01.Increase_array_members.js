/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = [];
    array.length = input;

    for (let i = 0; i < array.length; i += 1) {
        array[i] = i;
    }

    for (let i = 0; i < array.length; i++) {
        console.log(array[i] * 5);
    }
}
solve(['20']);
