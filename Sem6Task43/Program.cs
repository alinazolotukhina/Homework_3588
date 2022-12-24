// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = ReadData("Введите b1: ");
double k1 = ReadData("Введите k1: ");
double b2 = ReadData("Введите b2: ");
double k2 = ReadData("Введите k2: ");
double res = IntersectionPoint(b1, k1, b2, k2);
PrintData("Пересечение в точке: " + res);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

double IntersectionPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return x;
    return y;
}
