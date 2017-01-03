/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let counter = 1,
        maxNumber = +input[0];
    for (let i = 1; i <= input[0]; i += 1) {
        let line = '';

        for (let j = counter; j <= maxNumber; j += 1) {
            line += " " + j;
        }
        console.log(line);
        counter += 1;
        maxNumber += 1;
    }
}
solve(['20']);
