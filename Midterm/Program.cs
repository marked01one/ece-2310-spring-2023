using System;

namespace Midterm
{
  /// Create a new instance of the Program class 

  public class Program
  {
    public static void Main(string[] args)
    {
      Q1 q1 = new Q1();

      Q2 q2 = new Q2();

      Console.WriteLine("\n\nProblem 3.\na)");
      Q3_a();
      Console.WriteLine("\nb)");
      Q3_b();
      Console.WriteLine("\ne)");
      Q3_e();

      Console.WriteLine("\n\nProblem 4.\na)");
      Q4_a();
      Console.WriteLine("\nb)");
      Q4_b();

      

    }

    public static void Q3_a()
    {
      Complex p = new Complex();
      Complex q = new Complex();

      p.SetComplex(1, 1);
      q.SetComplex(1, -1);

      p.mulfix(q);
      p.print();
    }

    public static void Q3_b()
    {
      Complex p = new Complex();

      p.SetComplex(1, 1);

      p.mulfix(p);
      p.print();
    }

    public static void Q3_d()
    {
      Complex r = new Complex(); r.SetComplex(1,1);
      Complex rq = new Complex(); rq.SetComplex(1,-1);
      r.div(rq);

      Complex s = new Complex(); s.SetComplex(1,-1);
      Complex sq = new Complex(); sq.SetComplex(1,1);
      s.div(sq);
    }

    public static void Q3_e()
    {
      Complex r = new Complex(); r.SetComplex(1,1);
      Complex rq = new Complex(); rq.SetComplex(1,-1);
      r.div(rq);

      Complex s = new Complex(); s.SetComplex(1,-1);
      Complex sq = new Complex(); sq.SetComplex(1,1);
      s.div(sq);

      r.mulfix(s);

      r.print();
    }


    public static void Q4_a()
    {
      Point P1 = new Point(); P1.setPoint(1,0);
      Point P2 = new Point(); P2.setPoint(0,1);
      Point P3 = new Point(); P3.setPoint(-1,0);
      Point P4 = new Point(); P4.setPoint(0,-1);

      double P1P2 = P1.dist(P2);
      double P2P3 = P2.dist(P3);
      double P3P4 = P3.dist(P4);
      double P4P1 = P4.dist(P1);

      double P1P3 = P1.dist(P3);

      if (
        P1P2.CompareTo(P2P3) == 0 && 
        P1P2.CompareTo(P3P4) == 0 && 
        P1P2.CompareTo(P4P1) == 0 &&
        P1P3.CompareTo(
          Math.Sqrt(Math.Pow(P1P2, 2) + Math.Pow(P2P3, 2))
        ) == 0
      )
      {
        Console.WriteLine("The given points forms a square!");
      }
    }

    public static void Q4_b()
    {
      Point R1 = new Point(); R1.setPoint(3,0);
      Point R2 = new Point(); R2.setPoint(0,4);
      Point R3 = new Point(); R3.setPoint(-3,0);
      Point R4 = new Point(); R4.setPoint(0,-4);

      double R1R2 = R1.dist(R2);
      double R2R3 = R2.dist(R3);
      double R3R4 = R3.dist(R4);
      double R4R1 = R4.dist(R1);


      double R1R3 = R1.dist(R3);

      if (
        R1R2.CompareTo(R2R3) == 0 && 
        R2R3.CompareTo(R3R4) == 0 && 
        R1R2.CompareTo(R4R1) == 0 &&
        R1R3.CompareTo(
          Math.Sqrt(Math.Pow(R1R2, 2) + Math.Pow(R2R3, 2))
        ) == 0
      )
      {
        Console.WriteLine("The given points form a square!");
      } else {
        Console.WriteLine("The given points does not form a square!");
      }
    }
  }
}
