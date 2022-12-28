//                                 Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if (M >= N) return outRes + N;
     outRes = M + " " + RecMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
string resultLine = number1<number2? RecMN(number1, number2):RecMN(number2, number1);
PrintResult(resultLine);


// string RecMN(5, 10)
// {
//     if (5 >= 10) return outRes + N;
//      outRes = 5 + " " +  6 + " " +  7 + " " + 8 + " " + 9 + " " + 10;
//     return outRes;
// }

// string RecMN(6, 10)
// {
//     if (6 >= 10) return outRes + N;
//      outRes = 6 + " " +  7 + " " + 8 + " " + 9 + " " + 10;
//     return outRes;
// }

// string RecMN(7, 10)
// {
//     if (7 >= 10) return outRes + N;
//      outRes = 7 + " " + 8 + " " + 9 + " " + 10;
//     return outRes;
// }

// string RecMN(8, 10)
// {
//     if (8 >= 10) return outRes + N;
//      outRes = 8 + " " + 9 + " " + 10;
//     return outRes;
// }
// string RecMN(9, 10)
// {
//     if (9 >= 10) return outRes + N;
//      outRes = 9 + " " + 10;
//     return outRes;
// }

// string RecMN(10, 10)
// {
//     if (10 >= 10) return outRes + 10;
//      outRes = 9 + " " + RecMN(9 + 1, 10);
//     return outRes;
// }
