System.Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(System.Console.ReadLine());
int result = numberFirst / numberSecond;
if (numberFirst % numberSecond == 0) System.Console.WriteLine("Кратно");
else System.Console.WriteLine($"не кратно, остаток от деления {result}");
