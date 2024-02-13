void Main()
{
    System.Console.WriteLine("Введите значение для переменной a");
int a = ReadInt("Введите значение для а");
int b = ReadInt("Введите значение для b");
int c = ReadInt("Введите значение для c");
int d = ReadInt("Введите значение для d");
int e = ReadInt("Введите значение для e");
int f = ReadInt("Введите значение для f");
int result = a+b+c+d+e+f;
System.Console.WriteLine(result);

// int result = SunTwoNumbers(a,b);
// System.Console.WriteLine(result);
}
int ReadInt(String msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}


// int SunTwoNumbers(int firstNumber, int SecondNumber)
// {
//     return (int) Math.Pow(firstNumber+SecondNumber,2);
// }
Main();