
//  Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//  Программа завершается при вводе символа ‘q’ или при вводе числа, 
//  сумма цифр которого чётная.
void Main()
{
    for (; ; )
    {
        string UserInput = GetUserInput("Введите числовое значение или 'q' для завершения работы программы: ");
        if (UserInput == "q")
        {
            System.Console.WriteLine("Завершение работы программы...");
            break;
        }
        int Digit;
    
        if (int.TryParse(UserInput, out Digit))
        {
            int sum=0;
            while(Digit != 0 && Digit>0)
            {
                sum = sum + Digit%10;
                Digit = Digit/10;
            }
            if (sum %2==0)break;
        }
        else System.Console.WriteLine("Вы ввели не числовое значение!. либо Вы ввели не трехзначное число");

    }

}
string GetUserInput(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToString(System.Console.ReadLine());
}

Main();