function solve(input) {
    var FirstPoint = parseFloat(input[0]);
    var SecondPoint = parseFloat(input[1]);

    var result = Math.sqrt((Math.pow((FirstPoint - 0), 2)) + (Math.pow((SecondPoint - 0), 2)));

    if (result < 2 || result == 2) {
        console.log('yes ' + result.toFixed(2));
    } else {
        console.log('no ' + result.toFixed(2));
    }
}

solve(['1', '1.655']);
