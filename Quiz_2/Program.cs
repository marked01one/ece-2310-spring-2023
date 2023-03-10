namespace Quiz_2
{
  public class Program
  {
    public static int Main(string[] args)
    {
      
      
      Q2_b(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
      Console.Write("\n\n");
      Q2_c(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));


      
      return 0;
    }

    public static void Q1(int num)
    {
      Console.WriteLine(string.Format("\n\nThe number given: {0}", num));

      int sum = 0;
      while (num > 0)
      {
        sum *= 10;
        sum += num % 10;
        num /= 10;
      }

      Console.WriteLine(string.Format("The number reversed: {0}", sum));
      Console.WriteLine(string.Format("The number reversed times 3: {0}", sum * 3));
    }

    public static void Q2_b(double min_ppl, double max_ppl)
    {
      // Helper factorial functions
      for (double i = min_ppl; i <= max_ppl; i++)
      {
        if ((i-1) % 5 == 0) Console.Write("\n");
        
        double res = 1;
        
        for (int j = 0; j < i; j++)
        {
          res = res * (365-j) / 365;
        }

        Console.Write(string.Format("{0:N6}\t", 1 - res));
      }
    }

    public static void Q2_c(int min_ppl, int max_ppl)
    {
      // Helper factorial functions
      for (int i = min_ppl; i <= max_ppl; i++)
      {
        double res = 1;
        
        for (int j = 0; j < i; j++)
        {
          res = res * (365-j) / 365;
        }
        
        if ((1 - res).CompareTo(0.9) >= 0)
        {
          Console.WriteLine(string.Format("The probability will be higher than 0.9 at {0} people", i));
          break;
        }
      }
    }
  }
}