
Console.Clear();
int Main(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int naturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{naturalNumber(n, m + 1)}, ");
  return m;
}

int n = Main("Input N: ");
int m = Main("Input M: ");
if (n < m)
{
  Console.WriteLine("n needs to be bigger then m");
  return;
}
Console.WriteLine(naturalNumber(n, 1));
