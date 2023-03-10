// See https://aka.ms/new-console-template for more information
using System;

namespace Exercise_1
{
  public class Program
  {
    public static int Main(string[] args)
    {
      ExtraCredits();
      
      return 0;
    }

    // This is problem 1
    public static void Problem_1()
    {
      Console.WriteLine("Enter your number string here: ");

      string numInput = Console.ReadLine();

      int sum = 0;

      Dictionary<char, int> numDict = new Dictionary<char, int>(){
        {'0', 0}, {'1', 1}, {'2', 2}, {'3', 3}, {'4', 4},
        {'5', 5}, {'6', 6}, {'7', 7}, {'8', 8}, {'9', 9} 
      };

      char[] numDictKeys = numDict.Keys.ToArray();

      foreach (char c in numInput)
      {
        if (!numDictKeys.Contains(c))
        {
          Console.WriteLine("Sorry! ");
          return;
        }

        sum += numDict[c];
      }

      Console.WriteLine(string.Format("The total of all digits: {0:D}", sum));

      return;
    }
    
    // This is problem 2
    public static void Problem_2()
    {
      Console.WriteLine("Enter the number of days in the 12 days of Christmas: ");

      string day = Console.ReadLine();

      if (day == "1")
      {
        Console.WriteLine(string.Format("It's the {0:D}st day of Christmas!", day));
      } else if (day == "2") {
        Console.WriteLine(string.Format("It's the {0:D}nd day of Christmas!", day));
      } else if (day == "3") {
        Console.WriteLine(string.Format("It's the {0:D}rd day of Christmas!", day));
      } else {
        Console.WriteLine(string.Format("It's the {0:D}th day of Christmas!", day));
      }
      
      return;
    }

    // This is problem 3
    public static void Problem_3()
    {
      Console.WriteLine("\nPROBLEM 3\n");
      Console.WriteLine("Enter your principal amount, in dollars: ");
      decimal amount = Convert.ToDecimal(Console.ReadLine());

      Console.WriteLine("Enter your interest rate, in percent: ");
      decimal monthlyRate = Convert.ToDecimal(Console.ReadLine()) / 100 / 12;

      Console.WriteLine("Enter your term in years: ");
      int years = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Amount\tCurrent Total");
      for (int i=0; i<years; i++)
      {
        decimal monthlyAmount = amount * monthlyRate;

        for (int j=1; j<=12; j++)
        {
          amount += monthlyAmount;

          Console.WriteLine($"{monthlyAmount:C} \t {amount:C}");
        }
      }



      return;
    }

    public static void ExtraCredits()
    {
      Console.WriteLine("\nEXTRA CREDITS\n");
      Console.WriteLine("Here are the values that fits:");

      int[] numArr = {0,1};

      for (int i=100; i<=499 ; i++)
      {
        bool isNum = true;
        string s_int = i.ToString();
        string s_res = (i * 2).ToString();

        if (s_int[0] == s_res[2] && s_int[0] != s_res[0] && s_int[0] != s_res[1] && s_int[2] != s_int[1])
        {
          foreach (int num in numArr)
          {
            if (s_int[1] == s_res[num] || s_int[2] == s_res[num])
            {
              isNum = false;
              break;
            }
          }

          if (isNum)
          {
            Console.WriteLine(string.Format("{0} * 2 = {1}", s_int, s_res));
          }
        }
      }
      return;
    }
  }
}
