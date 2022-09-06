int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = A(m,n);

Console.Write($"A = {functionAkkerman} ");

int A(int m, int n)
{
      if (m == 0)return n + 1;
      else if (n == 0) return A(m - 1, 1);
      else return A(m - 1,A (m, n - 1));
}

int InputNumbers(string input)
{
      Console.Write(input);
      int output = Convert.ToInt32(Console.ReadLine());
      return output;
}
