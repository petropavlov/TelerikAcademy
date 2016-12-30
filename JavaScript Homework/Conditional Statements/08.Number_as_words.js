/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(input) {
    const number = Number(input[0]),
        lastLetter = number % 10,
        secondLetter = ((number / 10) % 10) | 0,
        firstLetter = (number / 100) | 0,
        firstTenNumbersUpper = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'],
        firstTenNumbersLower = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'],
        secondTenNumbersUpper = ['Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'],
        secondTenNumbersLower = ['eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        fromTenToHundredUpper = ['Ten', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'],
        fromTenToHundredLower = ['ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    if (number < 10) {
        console.log(firstTenNumbersUpper[number]);
    }
    if (number > 10 && number < 20) {
        console.log(secondTenNumbersUpper[number - 11]);
    }
    if (number < 100 && number % 10 === 0 && number !== 0) {
        console.log(fromTenToHundredUpper[(number / 10) - 1]);
    }
    if (number > 20 && number < 100 && number % 10 !== 0) {
        console.log(fromTenToHundredUpper[secondLetter - 1] + ' ' + firstTenNumbersLower[lastLetter]);
    }
    if (number > 99 && number % 100 === 0) {
        console.log(firstTenNumbersUpper[(number / 100)] + ' hundred');
    }
    if (number > 99 && number % 10 !== 0 && secondLetter !== 0) {
        if (number % 100 < 20 && number % 100 > 10) {
            console.log(firstTenNumbersUpper[firstLetter] + ' hundred and ' + secondTenNumbersLower[(number % 10) - 1]);
        } else {
            console.log(firstTenNumbersUpper[firstLetter] + ' hundred and ' + fromTenToHundredLower[secondLetter - 1] + ' ' + firstTenNumbersLower[lastLetter]);
        }
    }
    if (number > 99 && number % 10 === 0 && number % 100 !== 0) {
        console.log(firstTenNumbersUpper[firstLetter] + ' hundred and ' + fromTenToHundredLower[secondLetter - 1]);
    }
    if (number > 99 && secondLetter === 0 && number % 100 !== 0) {
        console.log(firstTenNumbersUpper[firstLetter] + ' hundred and ' + firstTenNumbersLower[lastLetter]);
    }
}
solve(['250']);
