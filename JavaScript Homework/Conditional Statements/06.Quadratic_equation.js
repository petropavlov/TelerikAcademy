/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    let a = Number(input[0]);
    let b = Number(input[1]);
    let c = Number(input[2]);
    let discriminant = (Math.pow(b, 2)) - (4 * a * c);

    if (discriminant < 0) {
        console.log('no real roots');
    }
    if (discriminant === 0) {
        console.log('x1=x2=' + (-b / (2 * a)).toFixed(2));
    }
    if (discriminant > 0) {
        let x1 = ((-b) + (Math.sqrt(Math.pow(b, 2) - (4 * a * c)))) / (2 * a);
        let x2 = ((-b) - (Math.sqrt(Math.pow(b, 2) - (4 * a * c)))) / (2 * a);
        if (x1 < x2) {
            console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
        } else {
            console.log('x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2));
        }
    }
}
solve(['0.2', '9.572', '0.2']);
