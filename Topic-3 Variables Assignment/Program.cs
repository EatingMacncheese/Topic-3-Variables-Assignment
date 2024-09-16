namespace Topic_3_Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiago
            
            int roomNum, r, gradDate;
            string course, myName;
            r = 3;
            roomNum = 29;
            double price;
            price = 2.99;
            
            double circleArea = 3.14 * (r * 3);
            double a, b, hyp;
            a = 2;
            b = 3;
            

            course = "Computer Science!";

            Console.WriteLine("This room is #" + roomNum);
            Console.WriteLine("The price is " + price.ToString("C"));
            Console.WriteLine("I'm leaning about " + course);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            

            myName = "Tiago Teague-Violante";
            gradDate = 2026;

            Console.WriteLine("My name is " + myName + ", and i will graduate in " + gradDate);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine(Math.Round(circleArea, 1));

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            hyp = Math.Sqrt(a * a + b * b);
            Console.WriteLine("my favorite formula is a² + b² = c²");
            Console.WriteLine("Lets solve one. a = 2, b = 3.");
            Console.WriteLine("a² + b² = 13 ");
            Console.WriteLine("√13 = " + Math.Round(hyp, 1));
            




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit");
        }
    }
}
