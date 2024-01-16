namespace CalculateArea
{
    public class CalculateArea
    {
        public double Count(double circleRadius)
        {
            var circleArea = Math.PI * Math.Pow(circleRadius, 2);
            return Math.Round(circleArea, 3);
        }

        public double Count(double firstRectangleSide, double secondRectangleSide)
        {
            var rectangleArea = firstRectangleSide * secondRectangleSide;
            return Math.Round(rectangleArea, 3);
        }

        public double Count(double firstTriangleSide, double secondTriangleSide, double thirdTriangleSide)
        {
            //Вычисление площади реализовано через формулу Герона, поэтому три стороны
            var trianglePerimeter = firstTriangleSide + secondTriangleSide + thirdTriangleSide;
            var halfPerimeter = trianglePerimeter / 2;
            var triangleArea = Math.Sqrt(halfPerimeter * 
                (halfPerimeter - firstTriangleSide) * 
                (halfPerimeter - secondTriangleSide) * 
                (halfPerimeter - thirdTriangleSide));
            return Math.Round(triangleArea, 3);
        }

        public void IsTriangleStraight(double firstTriangleSide, double secondTriangleSide, double thirdTriangleSide)
        {
            if (
                (firstTriangleSide * firstTriangleSide + secondTriangleSide * secondTriangleSide == thirdTriangleSide * thirdTriangleSide) ||
                (firstTriangleSide * firstTriangleSide + thirdTriangleSide * thirdTriangleSide == secondTriangleSide * secondTriangleSide) ||
                (thirdTriangleSide * thirdTriangleSide + secondTriangleSide * secondTriangleSide == firstTriangleSide * firstTriangleSide)
                )
            {
                Console.WriteLine("Triangle is straight");
            }
            else
            {
                Console.WriteLine("Triangle isn't straight");
            }

        }
    }
}