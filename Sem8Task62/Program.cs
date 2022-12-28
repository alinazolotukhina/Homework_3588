// Напишите программу, которая заполнит спирально массив 4 на 4.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

// Генерируем массив
int[,] array = FillSpirale2Array(row, column);
// Печатаем заданный массив
PrintData("Исходный массив");
Print2DArray(array);

// Метод заполнения массива по спирали
int[,] FillSpirale2Array(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    int arraySize = countRow * countColumn;
    int count = 1;
    // Определяем количество повторов прохода по спирали. Определяем меньшую строну массива и делим на 2
    int minLength = countRow < countColumn ? countRow : countColumn;
  
    // Первый цикл по количеству проходов по спирали
    for (int k = 0; k < (minLength / 2) + 1; k++)
    {
        // первый проход (слева направо)
        for (int j = k; j < array2D.GetLength(1) - k; j++)
        {
            if (count <= arraySize)
            {
                array2D[k, j] = count;
                count++;
            }
            else break;
        }
        // второй проход (сверху вниз)
        for (int i = k + 1; i < array2D.GetLength(0) - k; i++)
        {
            if (count <= arraySize)
            {
                array2D[i, array2D.GetLength(1) - 1 - k] = count;
                count++;
            }
            else break;
        }
        // третий проход (справа налево)
        for (int j = array2D.GetLength(1) - 2 - k; j >= k; j--)
        {
            if (count <= arraySize)
            {
                array2D[array2D.GetLength(0) - 1 - k, j] = count;
                count++;
            }
            else break;
        }
        // четвертый проход (снизу вверх)
        for (int i = array2D.GetLength(0) - 2 - k; i > k; i--)
        {
            if (count <= arraySize)
            {
                array2D[i, k] = count;
                count++;
            }
            else break;
        }
    }
    return array2D;
}

//Метод  печати двумерного массива
void Print2DArray(int[,] matr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matr[i, j] % 16];
            Console.Write(matr[i, j] + "    ".Substring(matr[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
