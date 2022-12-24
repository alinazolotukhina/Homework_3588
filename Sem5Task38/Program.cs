// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

double min = double.MaxValue;
double max = double.MinValue;
double[] array = GenArray(6, 16, 20);
Print1DArr(array);
MinMax(array);
PrintData("Разница между максимальным и минимальным элементом массива равна " + (max-min));


//Генерируем массив 
double[] GenArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (new Random().Next(minValue, maxValue + 1))+(new Random().NextDouble());
    }
    return arr;
}

// Печатаем одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

void MinMax(double[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] > max) 
        {
            max = arr[i];
        }
        if(arr[i] < min) 
        {
            min = arr[i];
        }
    }
}


// Вывод результата
void PrintData(string res)
{
    Console.WriteLine(res);
}
