// Задача 50. 
// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 20);
        Console.Write(matrix[i, j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию элемента в строке ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию элемена в столбце ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
{
    Console.Write(matrix[x, y]);
}
else
{
    Console.Write($"{x}{y}" + "-> такого числа в массиве нет");
}
