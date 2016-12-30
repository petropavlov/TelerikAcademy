/* jshint esversion: 6 */

function solve(input) {
    let FirstNumber = parseFloat(input[0]);
    let SecondNumber = parseFloat(input[1]);
    let ThirdNumber = parseFloat(input[2]);

    if (FirstNumber >= SecondNumber && FirstNumber >= ThirdNumber) {
        console.log(FirstNumber);
    } else {
        if (SecondNumber >= FirstNumber && SecondNumber >= ThirdNumber) {
            console.log(SecondNumber);
        } else {
            if (ThirdNumber >= SecondNumber && ThirdNumber >= FirstNumber) {
                console.log(ThirdNumber);
            }
        }
    }
}

solve(['-0.1', '-0.5', '-1.1']);
