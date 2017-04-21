/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

    let numbers = input[0].split(' ');

    function getMax(x, y) {
        if (x > y) {
            return x;
        } else {
            return y;
        }
    }

    if (getMax(numbers[0], numbers[1]) > numbers[2]) {
        console.log(getMax(numbers[0], numbers[1]));
    } else {
        console.log(numbers[2]);
    }

}
solve(['45 66 51']);
