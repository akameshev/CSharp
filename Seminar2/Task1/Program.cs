Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99 && number < 1000)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    System.Console.WriteLine(firstNumber+""+secondNumber);
}
else System.Console.WriteLine("Вы ввели не трехзначное число");