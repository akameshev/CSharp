// Задайте массив из N случайных целых чисел (N вводится с 
// клавиатуры). 
// Найдите количество чисел, которые оканчиваются на 1 и 
// делятся нацело на 7.
void Main()
{

}
int [] GenerateArray(int size,int leftRange,int rightRange)
{
    int[]MyArray = new int[size];
    for(int i =0;i<MyArray.Length;i++)
    {
        Random rnd = new Random();
        MyArray[i] = rnd.Next(leftRange,rightRange);
    }
    return MyArray;
}
void PrintArray(int[]MyArray)
{
    for(int i=0;i<MyArray.Length;i++)
    {
        System.Console.WriteLine(string.Join(", ",MyArray));
    }
}
Main();