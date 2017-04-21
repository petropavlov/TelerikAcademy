/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = input,
        counter = 0,
        firstCounter = [],
        number,
        maxNumber = 0;

    for (let i = 1; i < array.length; i++) {
        for (let j = 1; j < array.length; j++) {
            if (array[i] === array[j]) {
                counter += 1;
            }
        }
        firstCounter[i] = counter;
        counter = 0;
    }
    for (let i = 0; i < firstCounter.length; i++) {
        if (maxNumber < +firstCounter[i]) {
            maxNumber = firstCounter[i];
            number = array[i];
        }
    }
    console.log(number + ` (${maxNumber} times)`);
}
solve(['13', '4', '4', '1', '4', '2', '2', '2', '2', '2', '2', '4', '9', '4']);
