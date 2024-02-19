// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элементы на 
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
void main()
{
    int ArraySize = Readint("Задайте размер массива");
    int[] Array = GenenarateArray(ArraySize, -10, 10);
    PrintArray(Array);
    ChangeArray(Array);
    System.Console.WriteLine();
    PrintArray(Array);

}
int Readint(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
int[] GenenarateArray(int size, int rightRange, int leftRange)
{
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(rightRange, leftRange - 1);
    }
    return myArray;
}
void PrintArray(int[] ArrayForPrint)
{
    for (int i = 0; i < ArrayForPrint.Length; i++)
    {
        System.Console.Write(ArrayForPrint[i] + "\t");
    }
}
void ChangeArray(int[] MyArray)
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        // MyArray[i] = -MyArray[i];
        MyArray[i] *= -1;
    }
}
main();

