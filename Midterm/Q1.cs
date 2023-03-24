using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm
{
  public class Q1
  {
    public Q1()
    {
      int[] Q1_test = {7531, 654321, 34663840};
      Console.Write("Problem 1.");
      foreach (int i in Q1_test) Function(i);
    }

    public static void Function(int it)
    {
      Console.WriteLine(string.Format("\n\nTEST CASE: {0}", it));
      int integer = it;

      int sumOfDigits = 0;

      while (integer != 0)
      {
        sumOfDigits += integer % 10;
        integer = integer / 10;
      }
      Console.WriteLine(string.Format("Sum of digits: {0}", sumOfDigits));

      string rev = Convert.ToString(it);
      string reversedString = "";

      for (int i = rev.Length - 1; i >= 0; i--)
      {
        reversedString += rev[i];
      }

      Console.WriteLine(string.Format("Reversed: {0}", reversedString));

      Console.WriteLine(string.Format("Triple Reversed: {0}", Convert.ToInt32(reversedString) * 3));
      

    }
  }
}