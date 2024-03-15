void Main()
{
    System.Console.WriteLine(Fact(0));
    // OpenMatreshka(5);
}
// void OpenMatreshka (int size)
// {


//     if(size==1)
//     {
//         System.Console.WriteLine("smalest");
//         return;
//     }
// System.Console.WriteLine($"Opening matreshka {size}");
//     OpenMatreshka(size-1);

// }
int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n * Fact(n - 1);
}
Main();