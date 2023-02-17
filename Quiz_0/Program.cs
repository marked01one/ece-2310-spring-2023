// See https://aka.ms/new-console-template for more information
using System;

namespace Quiz_0
{
  public class Program
  {
    public static int Main(string[] args)
    {
      Problem_1();
      Problem_2();
      return 0;
    }

    public static void Problem_1()
    {
      Console.WriteLine("I like to learn C#, this is John Doe.");
    }

    public static void Problem_2()
    {
      Console.WriteLine("What is your name? ");
      string? name = Console.ReadLine();

      Console.WriteLine("Give a number: ");
      int? number = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(string.Format("This is {0}, my lucky number is {1}",name, number));
    }
  }

  
}
