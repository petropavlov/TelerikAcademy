/* jshint esversion: 6 */

function solve(input) {
    let FirstNumber = +input[0];
    let SecondNumber = +input[1];
    let ThirdNumber = +input[2];

    if (FirstNumber === 0 || SecondNumber === 0 || ThirdNumber === 0) {
        console.log('0');
    } else if (FirstNumber > 0 && SecondNumber > 0 && ThirdNumber > 0) {
        console.log('+');
    } else if (FirstNumber > 0 && SecondNumber < 0 && ThirdNumber > 0) {
        console.log('-');
    } else if (FirstNumber > 0 && SecondNumber < 0 && ThirdNumber < 0) {
        console.log('+');
    } else if (FirstNumber > 0 && SecondNumber > 0 && ThirdNumber < 0) {
        console.log('-');
    } else if (FirstNumber < 0 && SecondNumber > 0 && ThirdNumber > 0) {
        console.log('-');
    } else if (FirstNumber < 0 && SecondNumber < 0 && ThirdNumber > 0) {
        console.log('+');
    } else if (FirstNumber < 0 && SecondNumber > 0 && ThirdNumber < 0) {
        console.log('+');
    } else if (FirstNumber < 0 && SecondNumber < 0 && ThirdNumber < 0) {
        console.log('-');
    }
}

solve(['-1', '-0.5', '-5.1']);
