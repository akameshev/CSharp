System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99)
{
    int result = number % 1000 / 100;
    System.Console.WriteLine(result);
}
else System.Console.WriteLine("В числе отсутствует третья цифра");