void Main()
{
    int[,] Matrix = GenerateMatrix(3, 5, 1, 10);
    PrintMatrix(Matrix);
    System.Console.WriteLine();
    ChangeMatrix(Matrix);
    PrintMatrix(Matrix);
}
int[,] GenerateMatrix(int rows, int columns, int minRange, int maxRange)
{
    int[,] Matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = rnd.Next(minRange, maxRange + 1);
        }
        System.Console.WriteLine();
    }
    return Matrix;
}
void PrintMatrix(int[,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{MyMatrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void ChangeMatrix(int[,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(0); i += 2)
        for (int j = 0; j < MyMatrix.GetLength(1); j += 2)
            MyMatrix[i, j] = (int)Math.Pow(MyMatrix[i, j], 2);
}
Main();