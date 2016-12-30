/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    const firstNumber = Number(input[0]),
        secondNumber = Number(input[1]),
        thirdNumber = Number(input[2]),
        fourthNumber = Number(input[3]),
        fifthNumber = Number(input[4]);

    if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber) {
        console.log(firstNumber);
    } else if (secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber) {
        console.log(secondNumber);
    } else if (thirdNumber >= fourthNumber && thirdNumber >= fifthNumber) {
        console.log(thirdNumber);
    } else if (fourthNumber >= fifthNumber) {
        console.log(fourthNumber);
    } else {
        console.log(fifthNumber);
    }
}
solve(['-3', '-0.5', '-1.1', '-2', '-0.1']);
