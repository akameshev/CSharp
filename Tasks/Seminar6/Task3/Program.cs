var x = "Леша на полке клопа нашел";
x = x.Replace(" ", "").ToLower();
Console.WriteLine(x);
var t = new string(x.Reverse().ToArray());
Console.WriteLine(t == x ? "Это палиндром" : "Это не палиндром");
