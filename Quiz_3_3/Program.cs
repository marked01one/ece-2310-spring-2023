using System;
using System.IO;

namespace Quiz_3_3
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("What part of Question 3 do you want to test? (3a, 3b, 3c)");
      string option = Console.ReadLine();
      
      Console.WriteLine($"\n\nQUESTION {option.ToUpper()}:\n\n");

      if (option == "3a") Question_3a();
      if (option == "3b") Question_3b();
      if (option == "3c") Question_3c();
    }

    public static void Question_3a()
    {
      Console.WriteLine("What file do you want to search in? (file must be in same directory as Program.cs)");

      string fileName = Console.ReadLine();

      string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

      Console.WriteLine($"Reading file: {fileName}");

      string text = File.ReadAllText(filePath);

      string[] textArr = text.Split(
        new char[] {' ', ',', '.', '\n', ':'},
        StringSplitOptions.RemoveEmptyEntries
      );
      
      int wordCount = 0;

      Console.WriteLine("What word to look for?");

      string wordToLookFor = Console.ReadLine();

      foreach (string word in textArr)
      {
        if (word.ToLower() == wordToLookFor.ToLower()) wordCount++;
      }

      Console.WriteLine($"The word `{wordToLookFor}` appears {wordCount} times in gettysburg.txt");

      return;
    }


    public static void Question_3b()
    {
      Console.WriteLine("What file do you want to search in? (file must be in same directory as Program.cs)");

      string fileName = Console.ReadLine();

      string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

      Console.WriteLine("Reading file: gettysburg.txt");

      string text = File.ReadAllText(filePath);

      string[] textArr = text.Split(
        new char[] {' ', ',', '.', '\n', ':'},
        StringSplitOptions.RemoveEmptyEntries
      );

      Console.WriteLine("What word to look for?");

      string wordToLookFor = Console.ReadLine();

      foreach (string word in textArr)
      {
        string wordLower = word.ToLower();
        if (wordLower.Contains(wordToLookFor.ToLower())) Console.WriteLine($"{word}");
      }
      return;
    }


    public static void Question_3c()
    {
      Console.WriteLine("What file do you want to search in? (file must be in same directory as Program.cs)");

      string fileName = Console.ReadLine();

      string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

      Console.WriteLine("Reading file: gettysburg.txt");

      string text = File.ReadAllText(filePath);

      string[] sentenceArr = text.Split('.');

      Console.WriteLine("What word to look for?");

      string wordToLookFor = Console.ReadLine();

      foreach (string sentence in sentenceArr)
      {
        string[] wordArr = sentence.Split(
          new char[] {' ', ',', '\n', ':'},
          StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in wordArr)
        {
          string wordLower = word.ToLower();
          if (wordLower.Contains(wordToLookFor.ToLower())) 
            Console.WriteLine($"Word: \"{word}\", sentence: {sentence}\n");
        }
      }
      return;
    }
  }
}
