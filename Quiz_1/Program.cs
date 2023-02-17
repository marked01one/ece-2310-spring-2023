using System;

namespace Quiz_1
{
  public class Program
  {
    public static int Main(string[] args)
    {
      Q3();


      
      return 0;
    }

    public static void Q1()
    {
      int sum = 0;
      
      for (int i = 1; i <= 10; i++)
      {
        sum += i;
        Console.WriteLine($"Sum of 1 + 2 + 3 + ... + 10 is {sum} in iteration {i}");
      }
      return;
    }

    public static void Q2()
    {
      int sum = 0, j = 0;
      for (int i = 10; i >= 1; i--)
      {
        j++;
        sum += i;
        Console.WriteLine($"Sum of 10 + 9 + ... + 1 is {sum} in iteration {j}");
      }
      return;
    }

    public static void Q3()
    {
      Console.WriteLine("Enter for number of iterations n: ");
      int n = Convert.ToInt32(Console.ReadLine());

      int sum = 0;
      
      for (int i = 1; i <= n; i++)
      {
        sum += i;
        Console.WriteLine($"Sum of 1 + 2 + 3 + ... + 10 is {sum} in iteration {i}");
      }
      return;
    }
  }
}
