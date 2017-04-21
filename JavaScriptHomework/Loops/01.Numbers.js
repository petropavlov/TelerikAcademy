/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    const number = +input[0];
    let output = '';

    for (let i = 1; i <= number; i += 1) {
        output += i + ' ';
    }
    console.log(output);
}
solve(['5']);
