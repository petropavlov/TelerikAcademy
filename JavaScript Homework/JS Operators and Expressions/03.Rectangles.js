function solve(input) {
    var width = parseFloat(input[0]);
    var height = parseFloat(input[1]);

    var rectangleArea = width * height;
    var rectanglePerimeter = 2 * (width + height);

    console.log(rectangleArea.toFixed(2) + " " + rectanglePerimeter.toFixed(2));
}

solve(['2.5', '3']);
