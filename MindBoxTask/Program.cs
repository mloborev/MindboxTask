var calculateArea = new CalculateArea.CalculateArea();
//Count circle
var circle = calculateArea.Count(5);

//Count rectangle
var rectangle = calculateArea.Count(5, 7);

//Count triangle
var triangle = calculateArea.Count(5, 8, 10);

Console.WriteLine($"Circle area: {circle}\nRectangle area: {rectangle}\nTriangle area: {triangle}");

//Check if triangle is straight
calculateArea.IsTriangleStraight(3, 4, 5);
calculateArea.IsTriangleStraight(3, 7, 5);
