using System;

namespace Final_Indiv_3
{
  class Program
  {
    public struct Answer {
      public int n_terms { get; set; }
      public double answer { get; set; }
    }


    public static void Main(string[] args)
    {
      double[] errors = {1e-7, 1e-12, 1e-16};

      foreach (double e in errors)
      {
        Answer pi = myEnhancedPi(e);

        double absolute = Math.Abs(pi.answer - Math.PI);
        double relative = relativeError(pi.answer, Math.PI);

        Console.WriteLine($"pi w/ error {e}: {pi.answer} ({pi.n_terms} terms)");
        Console.WriteLine($"Absolute error: {absolute}");
        Console.WriteLine($"Relative error: {relative}\n\n");
      }
      
      
      return;
    }

    static Answer arctan(double input, double error)
    { 
      double answer = 0.0;
      double term = 1.0;
      int n_terms = 0;

      for (int n = 0; Math.Abs(term) >= error; n++)
      {
        term = Math.Pow(input, (2.0 * n + 1.0)) / (2.0 * n + 1.0);
        if (n % 2 == 0) {
          answer += term;
        } else {
          answer -= term;
        }
        n_terms++;
      }

      return new Answer{
        n_terms = n_terms,
        answer = answer
      };
    }

    static Answer myEnhancedPi(double error = 1e-7)
    { 
      Answer x = arctan(1.0 / 2.0, error), y = arctan(1.0 / 3.0, error);

      return new Answer {
        answer = 4.0 * (x.answer + y.answer),
        n_terms = (x.n_terms >= y.n_terms) ? x.n_terms : y.n_terms
      };
    }

    static double percentError(double real, double expected)
    {
      return (real - expected) / expected;
    }

    static double relativeError(double real, double expected)
    {
      return Math.Abs(percentError(real, expected));
    }
  }
}