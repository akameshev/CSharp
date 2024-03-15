// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из
// int size = Convert.ToInt32(System.Console.ReadLine());
// int[,] Matrix = new int[size,size];

using System.ComponentModel;

void Main()
{

    int[,] Matrix = GenerateMatrix(3, 5, 1, 1000);
    System.Console.Write("Elements of tehe matrix: ");
    PrintMatrix(Matrix);
    System.Console.WriteLine();
    System.Console.Write("Interesting: ");
    // System.Console.WriteLine();
    // System.Console.Write("Even elements of the matrix: ");
    // PrintEvenElements(Matrix);
    foreach (int e in Matrix)
    {
        if (Interesting(e) == true) System.Console.Write($"{e} ");
    }

    bool Interesting(int value)
    {
        int sumOfDigits = GetSumOfDigits(value);
        if (sumOfDigits % 2 == 0)
        {
            return true;
        }
        else return false;
    }

    int GetSumOfDigits(int value)
    {
        int sum = 0;
        while (value > 0)
        {
            sum = sum + value % 10;
            value = value / 10;
        }
        return sum;
    }

}
int[,] GenerateMatrix(int line, int column, int minRange, int maxRange)
{
    int[,] Matrix = new int[line, column];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(minRange, maxRange);
        }
    }
    return Matrix;
}
void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            System.Console.Write($"{Matrix[i, j]} ");
        }
    }
}


// void PrintEvenElements(int[,]MyMatrix)
// {
//     for (int i = 0; i < MyMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyMatrix.GetLength(1); j++)
//         {
//                 int num1=MyMatrix[i,j]%10;
//                 int num2=MyMatrix[i,j]/10;
//                 int sum = num1+num2;
//                 if(sum%2==0)System.Console.Write(MyMatrix[i,j]+" ");
//         }
//     }
// }
Main();