void Main()
{
    int N = ReadInt("Введите число: ");
    PrintNumber(N);
    Print();
}
int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
void PrintNumber(int number)
{
    if(number<1)return;
    PrintNumber(number-1);
    System.Console.Write(number+" ");
}
void Print()
{
    System.Console.WriteLine("Hi");
    return;
}
Main();