/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
let array = input,
numberToCheck = array.pop();
array.pop();
array.shift();

console.log(array.indexOf(numberToCheck));
}
solve(['10', '1', '2', '4', '8', '32', '31', '21', '64', '77', '99', '32']);
