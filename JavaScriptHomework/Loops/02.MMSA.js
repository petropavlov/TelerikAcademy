/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let sum = 0,
        average = 0,
        min = Number.MAX_SAFE_INTEGER,
        max = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < input.length; i += 1) {
        if (min >= +input[i]) {
            min = +input[i];
        }
        if (max <= +input[i]) {
            max = +input[i];
        }
        sum += +input[i];
    }

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + (average = (sum / input.length).toFixed(2)));
}
solve(['2', '-1', '4']);
