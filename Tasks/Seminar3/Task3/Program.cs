using System;
using System.Linq;
using System.Numerics;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double minDigit = numbers[0];
        for(int i=0;i<numbers.Length;i++)
        {
            if(minDigit>numbers[i]) minDigit = numbers[i];
        }
        return minDigit;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double maxDigit = numbers[0];
        for(int i=0;i<numbers.Length;i++)
        {
            if(maxDigit<numbers[i]) maxDigit = numbers[i];
        }
        return maxDigit;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        System.Console.WriteLine(FindMax(array)-FindMin(array));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
