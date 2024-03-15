// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
void Main()
{
    int m = 1;
    int n = 5;
    ShowNumbers(m, n);
}
void ShowNumbers(int m, int n)
{
    if (m > n) return;

    System.Console.WriteLine(m);
    ShowNumbers(m + 1, n);
}

Main();