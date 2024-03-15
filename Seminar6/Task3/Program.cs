// На основе символов строки (тип string) сформировать массив 
// символов (тип char[]). Вывести массив на экран.
using System.Runtime.InteropServices;

void Main()
{
    string? str = System.Console.ReadLine();
char[] chars = new char[str!.Length];
for (int i = 0;i<chars.Length;i++)
{
    chars[i] = str[i];
}
PrintArray(chars);

}
void PrintArray(char [] q)
{
    System.Console.WriteLine(string.Join(", ",q));
}
Main();

// for (int i = 0;i<chars.Length;i++)
// {
//     System.Console.WriteLine($"chars[{i}] = {chars[i]} ");
// }