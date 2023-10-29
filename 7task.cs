using System;

class Program
{
    static void Main()
    {
      int K = 3; // для примера
      int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      
      List<int> difference = new List<int>();
      HashSet<int> uniqueValues = new HashSet<int>();
      bool foundK = false;
      
      for (int i = 0; i < A.Length; i++)
      {
          if (A[i] % 2 == 0)
          {
              uniqueValues.Add(A[i]);
          }
      
          if (i + 1 > K)
          {
              foundK = true;
          }
      
          if (foundK)
          {
              uniqueValues.Remove(A[i]);
          }
      }
      
      difference.AddRange(uniqueValues);
      difference.Reverse();
      
      foreach (int num in difference)
      {
          Console.WriteLine(num);
      }

    }
}
