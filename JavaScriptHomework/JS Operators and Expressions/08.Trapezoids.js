function solve(input) {
    var a = parseFloat(input[0]);
    var b = parseFloat(input[1]);
    var h = parseFloat(input[2]);

    var area = (h / 2) * (a + b);
    console.log(area.toFixed(7));
}

solve(['0.222', '0.333', '0.555']);
