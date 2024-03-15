void Main()
{
    System.Console.WriteLine(Ackerman(2,1));
}
uint Ackerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}
Main();