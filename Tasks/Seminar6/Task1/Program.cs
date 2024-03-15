using System.Globalization;

void Main()
{
    char[,] chars =
    {
        {'a','b','v','n'},
        {'z','x','c','m'}
    };
    string str = "";
    for(int i=0;i<chars.GetLength(0);i++)
        for(int j=0;j<chars.GetLength(1);j++)
            str += chars[i,j];
    System.Console.WriteLine(str);
}

Main();