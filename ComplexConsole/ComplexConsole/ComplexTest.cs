using System;

public class ComPlexTest
{
    public static void Main(string[] args)
    {
        // create and initialize a Complex object
        Complex c1 = new Complex(), c2 = new Complex(), c3 = new Complex();
        Console.WriteLine("Create 1+j");
        c1.SetComplex(1, 1);
        Console.WriteLine("Print that");
        c1.print();
        Console.WriteLine("Create 1-j");
        c2.SetComplex(1, -1);
        Console.WriteLine(" (1+j) * (1-j) in the wrong way (correct answer is 2)");
        c1.mul(c2);
    //    c1.add(c2);

        c1.print();
        Console.WriteLine(" (1+j) * (1-j) in the right way (correct answer is 2)");
        c1.SetComplex(1, 1);
        c1.mulfix(c2);
        c1.print();




    }
}
