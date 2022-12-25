// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемена или же указание,что такого элемента нет.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}


void Print2DArrayColor(int[,] matrix)
{
 ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }

}

void PrintData(string msg, int meaning)
{
    Console.WriteLine(msg+meaning);
    
}
int SearchElem(int[,] array, int x, int y)
{
    int meaning = -1;
    if (x < array.GetLength(0))
    {
        if (y < array.GetLength(1))
        {
            meaning = array[x, y];
        }
    }
    return meaning; 
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int x = ReadData("Введите координату строки: ");
int y = ReadData("Введите координату столбца: ");
int[,] arr2D = Fill2DArray(row, column, 1, 16);
Print2DArrayColor(arr2D);


int meaning = SearchElem(arr2D,x,y);


if(meaning == -1)
{
PrintData("Ячейки с приведенными координатами нет", meaning);
}
else
{
    

PrintData("В ячейке с приведенными координатами хранится значение: " , meaning);
}
