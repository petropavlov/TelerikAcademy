/* jshint esversion: 6 */

function solve(input) {
    let FirstNumber = parseFloat(input[0]);
    let SecondNumber = parseFloat(input[1]);

    if (FirstNumber > SecondNumber) {
        console.log(SecondNumber + " " + FirstNumber);
    } else
        console.log(FirstNumber + " " + SecondNumber);
}

solve(['5.5', '4.5']);
