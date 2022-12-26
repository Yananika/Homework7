// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FindPosition(int[,] matrix, int rows, int columns)
{
    if (rows> matrix.GetLength(0) || columns > matrix.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine("В указанной позиции число " + matrix[rows - 1, columns - 1]);
}




int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}
int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int m = EnterData("Введите число строк: ");
int n = EnterData("Введите число столбцов: ");
int rows = EnterData("Введите номер строки: ");
int columns = EnterData("Введите номер столбца: ");

int [,] matrix = FillArray(m, n);

FindPosition(matrix, rows, columns);
