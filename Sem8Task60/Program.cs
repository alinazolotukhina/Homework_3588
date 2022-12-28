// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Печать цветного трехмерного массива

void Print3DArrayColor(int[,,] matrix)
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
            for (int k = 0; k < matrix.GetLength(2); k++)

            {
                Console.ForegroundColor = col[matrix[i, j, k] % 15];
                Console.Write(matrix[i, j, k] + "     ".Substring(matrix[i, j, k].ToString().Length));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
//метод заполнения трехмерного массива

void FillMatrix(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3D.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3D.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3D.GetLength(2); z++)
            {
                matrix3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

int row = ReadData("Введите первое значение координат трехмерного массива: ");
int column = ReadData("Введите второе значение координат трехмерного массива: ");
int list = ReadData("Введите третье значение координат трехмерного массива: ");
int[,,] matrix3D = new int[row, column, list];
FillMatrix(matrix3D);
Print3DArrayColor(matrix3D);
