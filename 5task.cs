using System;

class Program
{
    static void Main()
    {
      int D = 5; // можно любое другое число..
      int[] A = { 2, 7, 4, 9, 12, 6, 15, 8 };
      
      List<int> result = new List<int>();
      
      bool foundGreaterD = false;
      
      for (int i = 0; i < A.Length; i++)
      {
          if (A[i] > D)
          {
              foundGreaterD = true;
          }
      
          if (foundGreaterD && A[i] % 2 != 0 && A[i] > 0)
          {
              result.Add(A[i]);
          }
      }
      
      result.Reverse();
      
      foreach (int num in result)
      {
          Console.WriteLine(num);
      }

    }
}
