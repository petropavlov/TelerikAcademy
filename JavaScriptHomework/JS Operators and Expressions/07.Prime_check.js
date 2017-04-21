function solve(input) {

    var NumberToCheck = parseInt(input[0]);

    if (NumberToCheck < 1 || NumberToCheck == 1) {
        console.log('false');
    } else {
        if (NumberToCheck % 2 === 0 || NumberToCheck % 3 === 0 || NumberToCheck % 5 === 0 || NumberToCheck % 7 === 0) {
            if (NumberToCheck == 2 || NumberToCheck == 3 || NumberToCheck == 5 || NumberToCheck == 7) {
                console.log('true');
            } else {
                console.log('false');
            }
        } else {
            console.log('true');
        }
    }
}

solve(['31']);
