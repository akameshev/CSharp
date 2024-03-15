void Main()
{
    int[,] Matrix = GenerateMatrix(4, 4, 1, 10);
    PrintMatrix(Matrix);

    System.Console.WriteLine();
    PrintMatrix(SwapElements(Matrix));
    // int[]Array = ArrayIn(Matrix);
    System.Console.WriteLine("Массив сумм строк");
    // PrintArray(Array);
    int[] SumaStrok = SumOfRows(Matrix);
    PrintArray(SumaStrok);
    System.Console.WriteLine();
    System.Console.WriteLine(MinSumIndex(SumaStrok));

}
int[,] GenerateMatrix(int raw, int col, int minRange, int maxRange)
{
    int[,] MyMatrix = new int[raw, col];
    Random rand = new Random();
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            MyMatrix[i, j] = rand.Next(minRange, maxRange);
        }
        System.Console.WriteLine();
    }
    return MyMatrix;
}

void PrintMatrix(int[,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{MyMatrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SwapElements(int[,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(1); i++)
    {
        var temp = MyMatrix[0, i];
        MyMatrix[0, i] = MyMatrix[MyMatrix.GetLength(0) - (MyMatrix.GetLength(0) - 1), i];
        MyMatrix[MyMatrix.GetLength(0) - (MyMatrix.GetLength(0) - 1), i] = temp;

    }
    return MyMatrix;
}
int MinSumIndex(int[] MyArray)
{
    int min = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[min] > MyArray[i]) min = i;

    }
    return min+1;

}
// int [] ArrayIn (int [,]MyMatrix)
// {
//     int[]ArrayInMatrix = new int[MyMatrix.GetLength(1)];
//     for (int i=0;i<ArrayInMatrix.Length;i++)
//     {
//         ArrayInMatrix[i] = MyMatrix[MyMatrix.GetLength(0)-1,i];
//     }
//     return ArrayInMatrix;
// }
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{Array[i]}\t");
    }
}

int[] SumOfRows(int[,] MyMatrix)
{
    int[] SumInLines = new int[MyMatrix.GetLength(0)];
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            SumInLines[i] += MyMatrix[i, j];
        }
    }
    return SumInLines;
}
Main();