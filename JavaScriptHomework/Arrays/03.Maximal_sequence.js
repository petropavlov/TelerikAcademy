/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let array = input,
        newArray = [],
        a = 0,
        maxNumber = 0,
        counter = 1;

    for (let i = 1; i <= array.length; i++) {
        if (array[i] === array[i + 1]) {
            counter += 1;
        } else {
            newArray[a] = counter;
            a++;
            counter = 1;
        }
    }
    for (let i = 0; i < newArray.length; i++) {
        if (maxNumber < newArray[i]) {
            maxNumber = newArray[i];
        }
    }
    console.log(maxNumber);
}
solve(['3', '2', '2', '2', '2', '2', '2', '3', '1', '1', '1', '1', '1', '1', '1']);
