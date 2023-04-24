namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            //int a = 17;
            //int b = 4;

            //Console.WriteLine($"Addition: a + b = {a + b}");
            //Console.WriteLine($"Subtraction: a - b = {a - b}");
            //Console.WriteLine($"Multiplication: a * b = {a * b}");
            //Console.WriteLine($"Dvision: a / b = {a / b}");
            //Console.WriteLine($"Modulus: a % b = {a % b} \n ");

            //int quotient = a / b;
            //int remainder = a % b;

            //Console.WriteLine($"{a}/{b} is {quotient} remainder of {remainder}");

            //Exercise 2 - Call - version 1

            //Console.WriteLine("What is the radius of your circle?");
            //var userRadius = double.Parse(Console.ReadLine());

            //Console.WriteLine($"The area of a circle with a radius of {userRadius} is {AreaOfCircle(userRadius)}.");

            //Exercise 2 - call - version 2
            Console.WriteLine($"Area: {AreaOfCircle(26)}");
            Console.WriteLine($"Area: {AreaOfCircle(53)}");

            //Thought Exercise
            //var i = 3;
            //var j = 4;
            //var k = ++i * j++;

            //Console.WriteLine(k); // k = 16

        }
        //Exercise 2 - version 1
        //public static double AreaOfCircle(double radius)

        //{

        //    var area = Math.PI * Math.Pow(radius, 2);
        //    return area;

        //}

        //Exercise 2 - version 2
        public static double AreaOfCircle(double radius)
        {
            //Console.WriteLine("What is the radius of your circle?");

            //var userInput = double.Parse(Console.ReadLine());

            Console.WriteLine($"Radius: {radius}");
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
                       

        }



    }
}



