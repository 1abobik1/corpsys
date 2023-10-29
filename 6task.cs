      int D = 5; // для примера
      int K = 3; // для примера 
      int[] A = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
      
      List<int> union = new List<int>();
      HashSet<int> uniqueValues = new HashSet<int>();
      
      for (int i = 0; i < A.Length; i++)
      {
          if (A[i] >= D)
          {
              break;
          }
          uniqueValues.Add(A[i]);
      }
      
      for (int i = K - 1; i < A.Length; i++)
      {
          uniqueValues.Add(A[i]);
      }
      
      union.AddRange(uniqueValues);
      union.Sort((a, b) => b.CompareTo(a));
      
      foreach (int num in union)
      {
          Console.WriteLine(num);
      }
