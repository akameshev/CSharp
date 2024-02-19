// Найдите произведения пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и 
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары
void Main()
{
    int number = InputArrayValue("Введите длинну массива: ");
    int [] Array = GenerateArray(number,0,10);
    PrintArray(Array);

}
int [] GenerateArray(int size,int leftRange, int rightRange)
{
    int[]MyArray = new int[size];
    for(int i=0;i<MyArray.Length;i++)
    {
        MyArray[i] = new Random().Next(leftRange, rightRange);
    }
    return MyArray;
}
int InputArrayValue(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
void PrintArray(int[]ArrayForPrint)
{
    for(int i=0;i<ArrayForPrint.Length;i++)
    {
        System.Console.Write(ArrayForPrint[i]+" ");
    }
}
Main();