void Main()
{
    int arraySize = InputUserSize("задайте длину массива");
    int[] Array = GenerateArray(arraySize, 0, 100);
    PrintArray(Array);
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine(SumOfElements(Array));
    System.Console.WriteLine();
    System.Console.WriteLine(ProductOfElements(Array));

}
int InputUserSize(string msg)
{
    System.Console.Write($"{msg} ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < MyArray.Length; i++)
    {
        Random rnd = new Random();
        MyArray[i] = rnd.Next(leftRange, rightRange);
    }
    return MyArray;
}
int SumOfElements(int[] MyArray)
{
    int sum = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        sum += MyArray[i];
    }
    return sum;
}

int ProductOfElements(int[] MyArray)
{
    int product = 1;
    for (int i = 0; i < MyArray.Length; i++)
    {
        product = product * MyArray[i];
    }
    return product;
}
void PrintArray(int[] MyArray)
{
    for (int i = 0; i < MyArray.Length; i++) System.Console.Write(MyArray[i] + " ");
}
Main();
