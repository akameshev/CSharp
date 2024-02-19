void Main()
{
    int[,] table = GenerateMatrix(3,5);
    PrintMatrix(table);
    Random rnd = new Random();
    // for (int i = 0; i < table.GetLength(0); i++)
    // {
    //     for (int j = 0; j < table.GetLength(1); j++)
    //     {
    //         table[i, j] = rnd.Next(1, 11);
    //     }
    // }
    // for (int i = 0; i < table.GetLength(0); i++)
    // {
    //     System.Console.WriteLine();
    //     for (int j = 0; j < table.GetLength(1); j++)
    //     {
    //         System.Console.Write($"{table[i, j]} ");
    //     }
    // }
}
int[,] GenerateMatrix(int line, int column)
{
    int[,] Matrix = new int[line,column];
    for(int i=0;i<Matrix.GetLength(0);i++)
    {
        for(int j=0;j<Matrix.GetLength(1);j++)
        {
            Matrix[i,j]= new Random().Next(1,11);
        }
    }
    return Matrix;
}
void PrintMatrix(int[,]Matrix)
{
    for(int i=0;i<Matrix.GetLength(0);i++)
   {
    System.Console.WriteLine();
        for(int j=0;j<Matrix.GetLength(1);j++)
        {
            System.Console.Write($"{Matrix[i,j]} ");
        }
    } 
}

Main();