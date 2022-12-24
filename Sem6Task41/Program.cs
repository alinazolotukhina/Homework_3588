// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int number = ReadData("Введите количество чисел: ");
int countPositivNum = CountPositivNum(number);
PrintData("Количество чисел больше нуля: " + countPositivNum);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит данные
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод подсчета чисел больше нуля
int CountPositivNum(int num)
{
    int res = 0;
    while (num > 0)
    {
        if (ReadData("Введите число и нажмите Enter: ") > 0) res++;
        num = num - 1;
    }
    return res;
}
