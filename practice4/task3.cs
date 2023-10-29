using System;

class Program
{
    static void Main()
    {
      int L = 3; // можно любое другое число..
      string[] A = { "Apple", "123abc", "45defg", "Xyz987" };
    
      string result = "Not found";
      
      for (int i = A.Length - 1; i >= 0; i--)
      {
          if (A[i].Length == L && Char.IsDigit(A[i][0]))
          {
              result = A[i];
              break;
          }
      }
      
      Console.WriteLine(result);

    }
}
