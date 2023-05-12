using System;

namespace Exercise_4_2
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Input matrix square size:");

      int n = Convert.ToInt32(Console.ReadLine()); 

      int[,] matrix = new int[n,n];

      int row = 0, col = n/2;

      matrix[row,col] = 1;

      for (int i = 2; i <= n*n; i++) {
        if (matrix[(row + 1) % n,(col + 1) % n] == 0) {
          row = (row + 1) % n;
          col = (col + 1) % n;
        }
        else {
            row = (row - 1 + n) % n;
            // don't change col
        }
        matrix[row,col] = i;
      }

      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) 
        {
          Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
      }

      return;
    }
  }
}