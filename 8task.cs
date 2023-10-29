
      int K = 2; // можно любое другое число..
      string[] A = { "ABC123", "DEF456", "GHI789", "JKL", "MNOXYZ", "PQR123", "STU" };
      
      List<string> intersection = new List<string>();
      HashSet<string> uniqueValues = new HashSet<string>();
      bool foundLastDigit = false;
      
      for (int i = 0; i < A.Length; i++)
      {
          if (i < 3 * K)
          {
              uniqueValues.Add(A[i]);
          }
      
          if (!foundLastDigit && A[i].Any(char.IsDigit) && char.IsDigit(A[i].Last()))
          {
              foundLastDigit = true;
          }
      }
      
      for (int i = A.Length - 1; i >= 0; i--)
      {
          if (foundLastDigit && i >= 3 * K)
          {
              uniqueValues.Add(A[i]);
          }
      }
      
      intersection.AddRange(uniqueValues.OrderBy(s => s.Length).ThenBy(s => s));
      
      foreach (string str in intersection)
      {
          Console.WriteLine(str);
      }
