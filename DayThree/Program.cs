using System;



namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Point p1 = new Point(3, 4);
            Point p2 = new Point(5,2);

            Rectangle rec = new Rectangle(p1, p2);
            Square sqa = new Square(p1, p2);


            Console.WriteLine(rec.calculateayrea());
            Console.WriteLine(sqa.calculateayrea());

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
