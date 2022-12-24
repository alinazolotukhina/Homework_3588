// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях


int[] array = GenArray(15, 10, 60);
Print1DArr(array);
int result = SumOdd(array);
Console.WriteLine();
PrintData("Сумма элементов массива, стоящих на нечетных позициях, равна ", result);

//Генерируем массив 
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Печатаем одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Сумма элементов массива, стоящих на нечетных позициях
int SumOdd (int[] arr)
{
    int res = 0;
    int i = 1;
    while(i<arr.Length)
    {
        res+=arr[i];
        i = i+2;
    }
    return res;
}

// Вывод результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

