﻿System.Console.WriteLine("Введите значение для проверки кратности числа 7 и 23");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number%7==0 && number%23==0)System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");