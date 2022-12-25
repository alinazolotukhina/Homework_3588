// Задайте двухмерный массив из целых чисел. Найдете среднее арифметическое в каждом столбце.


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
    int[,] arr2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = rand.Next(1,16 );
        }
    }
    return arr2D;
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
            Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }

}

double[] Average(int [,] arr2D )
{
    double[] avg = new double [arr2D.GetLength(1)];
    for (int j=0;j<arr2D.GetLength(1);j++)
    {
       
        for(int i=0;i<arr2D.GetLength(0);i++)
        {
            avg[j]+= arr2D[i,j];
        }
        avg[j]=avg[j]/arr2D.GetLength(0);
    }
    return avg;
}
void Print1DArr(double[] array)//Печатаем массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",  ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column,1,16);
Print2DArrayColor(arr2D);
double [] avg = Average (arr2D);
Console.WriteLine();
Print1DArr(avg);
