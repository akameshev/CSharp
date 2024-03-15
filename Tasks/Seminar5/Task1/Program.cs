using System.ComponentModel;
using System.Reflection.Metadata;

void Main()
{
    int[,] Matrix = GenerateMatrix(3, 4, 1, 12);
    PrintMatrix(Matrix);
    System.Console.WriteLine();
    PrintResult(Matrix,2,2);
}
int[,] GenerateMatrix(int rows, int col, int minRange, int maxRange)
{
    int[,] MyMatrix = new int[rows, col];
    Random rnd = new Random();
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            MyMatrix[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return MyMatrix;
}
bool ValidatePosition(int[,] MyMatrix, int x, int y)
{
    if (x <= 0 || x >= MyMatrix.GetLength(0))
    {
        System.Console.WriteLine("Позиция по рядам выходит за границы Массива");
        return false;
    }
    if (y <= 0 || y >= MyMatrix.GetLength(1))
    {
        System.Console.WriteLine("Позиция по столбцам выходит за границы Массива");
        return false;
    }
    return true;
}

int FindElementByPosition(int[,] MyMatrix, int x, int y)
{
    return MyMatrix[x - 1, y - 1];
}
void PrintResult(int[,] MyMatrix, int x, int y)
{
    if (ValidatePosition(MyMatrix, x, y))
    {
        System.Console.WriteLine(FindElementByPosition(MyMatrix, x, y));
    }
}
void PrintMatrix(int[,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{MyMatrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
Main();