const PI = 3.14;
let area = 0;
function circleArea(radius) {
    return radius * radius * PI;
}

area = circleArea(3);
console.log("Area: ", area);

area = circleArea(4);
console.log("Area: ", area);