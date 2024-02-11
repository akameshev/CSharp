System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99 && number < 1000)
{
    int middleDigit = number % 100 / 10;
    int RightDigit = number % 100;
    //int index = 0;
    int result = 1;
    // while(index<RightDigit)
    // {    
    //     result = result * middleDigit;
    //     index++;
    // }
    // System.Console.WriteLine(result);
    for (; RightDigit > 0; RightDigit--)
    {
        result *= middleDigit;
    }
    System.Console.WriteLine(result);
}
else System.Console.WriteLine("Вы ввели не трехзначное число");