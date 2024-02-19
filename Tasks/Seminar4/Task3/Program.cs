// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int userInput = GetUserInput("Введите длинну массива");
    int[] Array = FillArray(userInput);
    System.Console.Write("Значения массива: ");
    PrintArray(Array);
    System.Console.WriteLine();
    ReverseArray(Array);
    System.Console.Write("Перевернутый массив: ");
    PrintArray(Array);
}
int GetUserInput(string msg)
{
    System.Console.WriteLine("Задайте длинну массива");
    return Convert.ToInt32(System.Console.ReadLine());
}
int[] FillArray(int size)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < MyArray.Length; ++i)
    {
        MyArray[i] = i + 1;
    }
    return MyArray;
}
int[] ReverseArray(int[] MyArray)
{
    for (int i = 0; i < MyArray.Length / 2; i++)
    {
        int temp = MyArray[i];
        MyArray[i] = MyArray[MyArray.Length - i - 1];
        MyArray[MyArray.Length - i - 1] = temp;
    }
    return MyArray;
}
void PrintArray(int[]MyArray)
{
        // for(int i=0;i<MyArray.Length;i++)
        // {
        //     System.Console.Write(MyArray[i]+" ");
        // }
        System.Console.WriteLine(string.Join(", ",MyArray));
}
Main();