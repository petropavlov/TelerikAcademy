"use strict";

function solve(input) {
    var numberToCheck = input[0];
    if (numberToCheck % 5 === 0 && numberToCheck % 7 === 0) {
        console.log("true " + numberToCheck);
    } else {
        console.log("false " + numberToCheck);
    }
}
