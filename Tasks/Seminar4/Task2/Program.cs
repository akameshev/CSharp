void Main()
{
    int inputArraySize = GetUserInput("Задайте длинну массива");
    int [] Array = GenerateArray(inputArraySize,100,999);
    System.Console.Write("Сгенирированный массив: ");
    PrintArray(Array);
    System.Console.WriteLine();
    int countOfEven = GetCountOfEven(Array);
    System.Console.Write("Количество четных элементов: ");
    System.Console.WriteLine(countOfEven);

}
int GetUserInput(string msg)
{
    System.Console.Write(msg+" ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] GenerateArray (int size, int leftRange, int rightRange)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < MyArray.Length; i++)
    {
        Random rnd = new Random();
        MyArray[i] = rnd.Next(leftRange, rightRange);
    }
    return MyArray;
}
int GetCountOfEven (int [] MyArray)
{
    int count = 0;
    for(int i=0;i<MyArray.Length;i++)
    {
        if(MyArray[i]%2==0)count=count+1;
    }
    return count;
}
void PrintArray(int[]MyArray)
{
    foreach(int i in MyArray)System.Console.Write(i+" ");
}


Main();