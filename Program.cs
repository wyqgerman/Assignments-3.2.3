namespace Assignments_3._2._3
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle c1, Circle c2)
        {
            return c1.CalculateArea() + c2.CalculateArea();
        }

        public static double operator -(Circle c1, Circle c2)
        {
            return Math.Abs(c1.CalculateArea() - c2.CalculateArea());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the first circle: ");
            double radius1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the radius of the second circle: ");
            double radius2 = double.Parse(Console.ReadLine());

            Circle circle1 = new Circle(radius1);
            Circle circle2 = new Circle(radius2);

            double totalArea = circle1 + circle2;
            Console.WriteLine($"The total area of the two circles is: {totalArea:F2}");

            double areaDifference = circle1 - circle2;
            Console.WriteLine($"The difference in the areas of the two circles is: {areaDifference:F2}");
        }
    }
}
