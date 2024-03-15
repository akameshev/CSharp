// Считать строку с консоли, состоящую из латинских 
// букв в нижнем регистре. Выяснить, сколько среди 
// введённых букв гласных
using System.Runtime.InteropServices.Marshalling;

void Main()
{
   string? inputString = System.Console.ReadLine();
   string findLetters = "euioay";
   int count = 0;
   foreach(char ch in inputString)
   {
    if(findLetters.Contains(ch))
    count ++;
   }
   System.Console.WriteLine(count);

}

Main();