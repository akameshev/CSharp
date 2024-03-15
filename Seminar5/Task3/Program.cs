// using System.Diagnostics.CodeAnalysis;

// void Main()
// {
//     int[,] Matrix = GenerateMatrix(4, 5, 1, 10);
//     PrintMatrix(Matrix);
//     System.Console.WriteLine(sumOfDiag(Matrix));
//     System.Console.WriteLine();
//     double []Array = GetRowAverage(Matrix);
//     PrintArray(Array);
// }
// void PrintArray(double[]Array)
// {
//     for(int i =0;i<Array.Length;i++)
//     {
//         System.Console.Write($"{Array[i]} ");
//     }
// }
// double[] GetRowAverage(int[,] matrix)
// {
//     double[] AverageArray = new double[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         double temp = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp += matrix[i, j];
//         }
//         AverageArray[i] = temp / matrix.GetLength(1);
//     }
//     return AverageArray;
// }

// int sumOfDiag(int[,] MyMatrix)
// {
//     int sum = 0;
//     for (int i = 0; i < MyMatrix.GetLength(0) && i < MyMatrix.GetLength(1); i++)
//         sum += MyMatrix[i, i];
//     return sum;
// }

// int[,] GenerateMatrix(int rows, int columns, int minRange, int maxRange)
// {
//     int[,] MyMatrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < MyMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyMatrix.GetLength(1); j++)
//         {
//             MyMatrix[i, j] = rand.Next(minRange, maxRange);
//         }
//     }
//     return MyMatrix;
// }
// void PrintMatrix(int[,] MyMatrix)
// {
//     for (int i = 0; i < MyMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyMatrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{MyMatrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }
// Main();
using System.ComponentModel;
using System.IO.Compression;

// void Main()
// {
//     Func(out int a, 7, 8);
//     System.Console.WriteLine(a);
//     int a2 = 0;
//     Func2(ref a2, 7, 8);
//     System.Console.WriteLine(a);
// }
// void Func(out int a, int b, int c)
// {
//     a = b * c;
// }
// void Func2(ref int a, int c, int d)
// {
//     a = c * d;
// }
// Main();

void Main()
{
    int input = InputUser("Ыыедите число");

}
int InputUser(string msg)
{
    
    if(int.TryParse(Console.ReadLine(),out int verify))
    {
        System.Console.WriteLine(verify);
    
    }
    else
    {
        System.Console.WriteLine("Ошибка еще раз ");
    }
    return verify;
    
}
Main();