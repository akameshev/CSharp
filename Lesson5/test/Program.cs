void Main()
{
 int[,] Matrix = GenerateMatrix(3,5,1,11);
 System.Console.WriteLine(Matrix.Length);
}
int[,] GenerateMatrix(int rows, int col, int minRange, int maxRange)
{
    int [,] MyMatrix = new int[rows,col];
    Random rnd = new Random();
    for(int i=0;i<MyMatrix.GetLength(0);i++)
    {
        for(int j=0;j<MyMatrix.GetLength(1);j++)
        {
            MyMatrix[i,j] = rnd.Next(minRange,maxRange);
        }
    }
    return MyMatrix;
}
Main();