// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
void Main()
{
    System.Console.Write("Введите строку: ");
    string inputString = System.Console.ReadLine()!.ToLower();
    PrintConsonant(inputString, 0);
}
bool IsConsonant(char c)
{
    return !"eyuioa".Contains(c);
}
void PrintConsonant(string inputString, int i)
{
    if (i >= inputString.Length) return;
    if (IsConsonant(inputString[i]))
        System.Console.Write(inputString[i] + " ");
    PrintConsonant(inputString, i+1);
}
Main();