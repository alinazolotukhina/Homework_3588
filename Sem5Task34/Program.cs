int[] array = GenArray(125, 250, 777);
Print1DArr(array);
int result = CountEvan(array);
Console.WriteLine();
PrintData("Количество четных чисел в массиве равно ", result);

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

// Счетчик четных чисел в массиве
int CountEvan(int[] arr)
{
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if((arr[i])%2 == 0) 
        res++;
    }
    return res;
}

// Вывод результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
