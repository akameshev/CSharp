System.Console.WriteLine("Введите значение для оси X: ");
int numberX = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение для оси Y: ");
int numberY = Convert.ToInt32(System.Console.ReadLine());
if (numberX != 0 && numberY != 0)
{
    if (numberX > 0 && numberY > 0) System.Console.WriteLine("точка координат находится в 1 четверти");
    else if (numberX < 0 && numberY > 0) System.Console.WriteLine("точка координат находится в 2 четверти");
    else if (numberX < 0 && numberY < 0) System.Console.WriteLine("точка координат находится в 3 четверти");
    else System.Console.WriteLine("точка координат находится в 4 четверти");
}
else System.Console.WriteLine("X и Y не могут быть равны нулю");