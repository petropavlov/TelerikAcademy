/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let FirstNumber = parseFloat(input[0]);
    let SecondNumber = parseFloat(input[1]);
    let ThirdNumber = parseFloat(input[2]);

    if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber) {

        if (SecondNumber >= ThirdNumber) {
            console.log(FirstNumber + " " + SecondNumber + " " + ThirdNumber);
        } else {
            console.log(FirstNumber + " " + ThirdNumber + " " + SecondNumber);
        }
    }
    if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber) {
        if (FirstNumber >= ThirdNumber) {
            console.log(SecondNumber + " " + FirstNumber + " " + ThirdNumber);
        } else {
            console.log(SecondNumber + " " + ThirdNumber + " " + FirstNumber);
        }
    }
    if (ThirdNumber > FirstNumber && ThirdNumber > SecondNumber) {
        if (FirstNumber >= SecondNumber) {
            console.log(ThirdNumber + " " + FirstNumber + " " + SecondNumber);
        } else {
            console.log(ThirdNumber + " " + SecondNumber + " " + FirstNumber);
        }
    }
    if (FirstNumber === SecondNumber && FirstNumber > ThirdNumber) {
        console.log(FirstNumber + " " + SecondNumber + " " + ThirdNumber);
    }
    if (FirstNumber === ThirdNumber && FirstNumber > SecondNumber) {
        console.log(FirstNumber + " " + ThirdNumber + " " + SecondNumber);
    }
    if (ThirdNumber === SecondNumber && ThirdNumber > FirstNumber) {
        console.log(ThirdNumber + " " + SecondNumber + " " + FirstNumber);
    }
    if (FirstNumber === SecondNumber && SecondNumber === ThirdNumber) {
        console.log(ThirdNumber + " " + SecondNumber + " " + FirstNumber);
    }

}
solve(['1', '1', '1']);
