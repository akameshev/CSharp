﻿// Создать целочисленный массив на 10 
// элементов и заполнить его произвольными 
// числами. Вывести на экран чётные элементы 
// массива.
// Лекция 2. Массивы
// Пример 1
// Массив: [1 5 4 6 9 3 2 5 4 1]
// Чётные: 4 6 2 4
// Пример 2
// Массив: [9 5 1 7 15 36 3 1 1 7]
// Чётные: 36
int[] arr = { 1, 5, 4, 6, 9, 3, 2, 5, 4, 1 };
int i =0;
// for(int i=0;i<arr.Length;i++)
// {
//     if(arr[i]%2==0)System.Console.WriteLine(arr[i]+" ");
    
// }
while(i<arr.Length)
{
    if(arr[i]%2==0)System.Console.WriteLine($"{arr[i]} ");
    i++;
}