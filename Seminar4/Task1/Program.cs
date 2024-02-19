void Main()
{
    int ArraySize = ReadInt("Введите длинну значения массива");
    int[]Array = GenerateArray(ArraySize,0,1000);
    Array[0] = 91;
    printArray(Array);
    System.Console.WriteLine();
    System.Console.WriteLine(countNumbers(Array));



}
int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

int [] GenerateArray(int size, int leftRange, int rightRange)
{
    int[]MyArray = new int[size];
    for(int i=0;i<MyArray.Length;i++)
    {
        MyArray[i]= new Random().Next(leftRange,rightRange);
    }
    return MyArray;
}

int countNumbers(int[]MyArray)
{
    int count =0;
    for(int i=0;i<MyArray.Length;i++)
    {
        if(MyArray[i]%10==1 && MyArray[i]%7==0)count++;
    }
    return count;
}
void printArray(int[]MyArray)
{
    for(int i=0;i<MyArray.Length;i++)
    {
        System.Console.Write(MyArray[i]+"\t");
    }
}
Main();