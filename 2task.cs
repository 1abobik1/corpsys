using System;
class Program
{
    static void Main()
    {
    int D = 5; // Замените D на нужное однозначное целое число
    int[] A = { 12, 35, 45, 18, 27, 0 };

    int result = 0;

    foreach (int num in A)
    {
        if (num > 0 && num % 10 == D)
        {
            result = num;
            break;
        }
    }

    Console.WriteLine(result != 0 ? result.ToString() : "0");
    }
}
