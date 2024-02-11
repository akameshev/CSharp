int[]arr={4,112,99,13,8};
int max = arr[0];
int index=0;

while(index<arr.Length)
{
    if(max<arr[index])max=arr[index];
    index++;

}
System.Console.WriteLine(max);
