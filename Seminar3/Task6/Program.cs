void Main()
{
int inputNumber = inputArraySize("Введите длинну массива: ");
int [] Array = GenerateArray(inputNumber,0,10);
printArray(Array);
System.Console.WriteLine();
printArray(findPair(Array));
// System.Console.WriteLine();
// reverseArray(Array);
// printArray(Array);
}
int [] GenerateArray(int size, int leftRange, int rightRange)
{
    int [] MyArray = new int[size];
    for(int i=0;i<MyArray.Length;i++)
    {
        MyArray[i] = new Random().Next(leftRange,rightRange);
    }
    return MyArray;
}
int inputArraySize(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
void printArray(int [] MyArray)
{
    for(int i =0; i<MyArray.Length;i++)
    {
        System.Console.Write(MyArray[i]+"\t");
    }
}
// void reverseArray(int[]MyArray)
// {
//     for(int i=0;i<MyArray.Length;i++)
//     {
//         MyArray[i] *= -1;
//     }
// }
int [] findPair(int [] MyArray)
{
    int [] newMyArray = new int[MyArray.Length/2];
    for(int i=0;i<MyArray.Length/2;i++)
    {
        newMyArray[i] = MyArray[i]*MyArray[MyArray.Length-1-i];
    }
    return newMyArray;
}
Main();