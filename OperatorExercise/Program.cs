namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            //int a = 17;
            //int b = 4;

            Console.WriteLine($"Addition: a + b = {a + b}");
            Console.WriteLine($"Subtraction: a - b = {a - b}");
            Console.WriteLine($"Multiplication: a * b = {a * b}");
            Console.WriteLine($"Dvision: a / b = {a / b}");
            Console.WriteLine($"Modulus: a % b = {a % b} \n ");

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder of {remainder}");


            //Exercise 2

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());


            double AreaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle}");

            //Thought Exercise
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // k = 16




        }
    }
}
