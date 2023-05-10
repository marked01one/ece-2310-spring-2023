using System;

public class PointTest
{
    public static void Main(string[] args)
    {
        double dist;
        Point p1 = new Point(), p2 = new Point();
        p1.setPoint(1, 2);
        p2.setPoint(4, 6);

        dist = p1.dist(p2);
        Console.Write("The distance between ");
        p1.print();
        Console.Write(" and ");
        p2.print();
        Console.WriteLine (" is {0}",dist);
        
    }
    
}
