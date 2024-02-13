using System.Drawing;

void Main()
{
    int arraySize = ReadInt("Задайте длинну массива: ");

    int[] array = GenerateArray(arraySize, 0, 9);
    printArray(array);
  
    int number = ReadInt("Введите искомое значение: ");
    bool NumberIsFined = numberIsExist(array,number);

    if (NumberIsFined == true) System.Console.WriteLine("Число найдено");
    else System.Console.WriteLine("Нет");
}
int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] MyArray = new int[size];

    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return MyArray;
}
void printArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        {
           System.Console.Write(arrayForPrint[i] + " ");
        }
}

bool numberIsExist (int []myArray,int number)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == number) return true; //ключевое слово return выходит из функции
    }
    return false;
}
Main();
