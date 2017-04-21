/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = input;

    if (array[0].length === array[1].length) {
        console.log('=');
    }
    if (array[0].length > array[1].length) {
        console.log('>');
    }
    if (array[0].length < array[1].length) {
        console.log('<');
    }
}
solve(['heoss', 'halo']);
