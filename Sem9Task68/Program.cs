// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System.Numerics;
ulong Akk(ulong n, ulong m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 ulong ReadData(string line)
{
    Console.Write(line);
    ulong number = ulong.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(ulong number )
{
    Console.WriteLine(number);
}
ulong m = ReadData("Введите первое число: ");
ulong n = ReadData("Введите второе число: ");
ulong number = Akk(n,m);
PrintResult( number );
