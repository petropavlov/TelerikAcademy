function solve(input) {
    var numberToCheck = parseInt(input[0]);
    var number = (Math.floor((numberToCheck / 100))) % 10;

    if (number === 7) {
        console.log('true');
    } else {
        console.log('false ' + number);
    }
}

solve(['877']);
