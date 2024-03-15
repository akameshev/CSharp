// void Main()
// {
//     int N = ReadInt("Введите число");
//     System.Console.WriteLine(SumDigitsInNumber(N));
//     System.Console.WriteLine(789%10);
//     System.Console.WriteLine(78%10);
//     System.Console.WriteLine(7%10);
// }
// int ReadInt(string msg)
// {
//     System.Console.WriteLine(msg);
//     return Convert.ToInt32(System.Console.ReadLine());
// }
// int SumDigitsInNumber(int number)
// {
//     if (number < 1) return number;
//     return number % 10 + SumDigitsInNumber(number / 10);
// }
// Main();






void Main()
{
    int N = ReadInt("Введите число: ");
}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
int SumOfDigits(int number)
{
    if (number < 1) return number;
    return number % 10 + SumOfDigits(number / 10);
}
Main();