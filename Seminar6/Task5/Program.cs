string str = "Hello+world+word";
var array = str.Split('+');
System.Console.WriteLine(string.Join(",",array));
System.Console.WriteLine(string.Join(",",array.Reverse()));