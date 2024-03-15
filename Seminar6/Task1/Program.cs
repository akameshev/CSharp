void Main()
{
    string? inputString = System.Console.ReadLine();
    string findedLetters = "aeiouy";

    int count = 0;
    foreach(char ch in inputString)
    {
        if(findedLetters.Contains(ch))
            count ++;
    }

    System.Console.WriteLine($"{count} гласных букв");
}

Main();


