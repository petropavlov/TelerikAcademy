/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {

    for (let i = +input; i >= 0; i -= 1) {
        if (i === 2 || i === 3 || i === 5 || i === 7 || i === 11 || i === 13 || i === 17) {
            console.log(i);
            break;
        } else {
            if (i % 2 !== 0 && i % 3 !== 0 && i % 5 !== 0 && i % 7 !== 0 && i % 11 !== 0 && i % 13 !== 0 && i % 17 !== 0) {
                console.log(i);
                break;
            }
        }
    }
}
solve(['361']);
