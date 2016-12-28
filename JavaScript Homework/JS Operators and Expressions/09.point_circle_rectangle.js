/* jshint esversion: 6 */

function solve(input) {
    let x = input[0],
        y = input[1],
        a = Math.pow((x - 1), 2),
        b = Math.pow((y - 1), 2),
        c = (a + b),
        InCircle = (Math.sqrt(c) <= 1.5);
    InRectangle = ((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1));
    var IsInCircle = (InCircle ? "inside circle" : "outside circle");
    var IsInRectangle = (InRectangle ? "inside rectangle" : "outside rectangle");
    console.log(IsInCircle, IsInRectangle);
}

solve(['2.5', '2']);
