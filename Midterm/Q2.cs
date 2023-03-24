using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm
{
    public class Q2
    {
      public Q2()
      {
        int[] Q2_test_a = {97, 197, 1997};
        Console.WriteLine("\n\nProblem 2.\na)");
        foreach (int i in Q2_test_a) Q2_a(i);
        Console.WriteLine("\nb)");
        Q2_b();
        Console.WriteLine("\nd)");
        int[] Q2_test_d = {100, 10000};
        foreach (int j in Q2_test_d) Q2_c(j);
      }

      public static void Q2_a(int n)
      {
        Console.WriteLine(string.Format("TEST CASE: {0}", n));
        for (int i = 2; i < n; i++)
        {
          if (n % i == 0)
          {
            Console.WriteLine(string.Format("The number {0} is not a prime number.", n));
            return;
          }
        }
        
        Console.WriteLine(string.Format("The number {0} is a prime number.", n));
        return;
      }

      public static void Q2_b()
      {
        int total = 0;
        int newLine = 0;
        bool isPrime = true;
        
        for (int i = 2; i <= 200; i++)
        {
          for (int j = 2; j < i; j++)
          {
            if (i % j == 0)
            {
              isPrime = false;
              break;
            }
          }

          if (!isPrime) {
            isPrime = true;
            continue;
          }

          total += 1;
          newLine += 1;
          if (newLine % 8 == 0) Console.Write(string.Format("{0}\n", i));
              
          Console.Write(string.Format("{0}\t", i));
        }
        
        Console.WriteLine(string.Format("\nThere are {0} prime numbers in total between 2 and 200.", total));
        return;
      }

      public static void Q2_c(int n)
      {
        int total = 0;
        bool isPrime = true;
        
        for (int i = 2; i <= n; i++)
        {
          for (int j = 2; j < i; j++)
          {
            if (i % j == 0)
            {
              isPrime = false;
              break;
            }
          }

          if (!isPrime) {
            isPrime = true;
            continue;
          }

          total += 1;
        }
        
        Console.WriteLine(string.Format("There are {0} prime numbers in total between 2 and {1}.", total, n));
        return;
      } 
    }
}