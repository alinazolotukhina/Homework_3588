// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Чтение данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int SumNumbers(int M, int N) //Нахождение суммы ряда чисел
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}
int M = ReadData("Введите первое число: ");

int N = ReadData("ВВедите второе число: ");
int res = SumNumbers(M, N);
PrintResult($"Сумма чисел равна: {SumNumbers(M, N)}");

