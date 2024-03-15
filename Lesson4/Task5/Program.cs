void Main()
{
    string str = System.Console.ReadLine();
    System.Console.WriteLine(GetLetters(str));

}
string GetLetters (string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters; 
}
Main();