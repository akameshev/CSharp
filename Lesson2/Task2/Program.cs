int n = 10;
int[] arr = new int[n];
int index = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = i + 1;
//     System.Console.WriteLine(arr[i]);
//}
while (index < arr.Length)
{
    arr[index] = index + 1;
    System.Console.WriteLine(arr[index]);
    index++;
}