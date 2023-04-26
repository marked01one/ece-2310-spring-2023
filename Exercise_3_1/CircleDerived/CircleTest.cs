using System;

public class CircleTest
{
    public static void Main(string[] args)
    {
        Circle c1 = new Circle(0, 0, 1), c2 = new Circle(1, 0, 1);
        Point p1 = new Point();
        p1.setPoint(0, 1);

        p1.print();
        Console.Write(", ");
        c1.print();
        Console.WriteLine();
        if (c1.onCircle(p1))
        {
           // Console.Write(" Point ");
            p1.print();
            Console.Write (" on ");
            c1.print();
            Console.WriteLine();
        }
        else
            Console.WriteLine("Point NOT on circle");

        if (c1.intersect(c2))
        {
           // Console.WriteLine("Two circles intersect");
            c1.print();
            Console.Write(" intersects ");
            c2.print();
            Console.WriteLine();
        }
        else

            Console.WriteLine("Two circles do NOT intersect");
    }
}
