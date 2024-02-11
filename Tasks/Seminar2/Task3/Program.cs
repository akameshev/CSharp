System.Console.WriteLine("Введите значение от 10 до 99");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 10 && number < 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    System.Console.WriteLine($"большее число {maxDigit}");
}