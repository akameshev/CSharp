// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
using System.Xml.Schema;

void Main()
{
    int [] Array = {1,55,85,77,4,9,8};
    int index = 0;
    ShowArrayElements(Array,index);
}
void ShowArrayElements(int[]MyArray, int i)
{
     if (i > MyArray.Length-1) return;
     ShowArrayElements(MyArray,i+1);
     System.Console.Write(MyArray[i]+" ");

}
Main();