// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}


double[,] CreateArray(int size1, int size2)
{
    Random rnd = new Random();
    double[,] array = new double[size1, size2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[i,x] = rnd.Next(-20,20) + rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int x = 0; x < array.GetLength(1); x++)
        {
            System.Console.Write($"{array[i,x]:F2} ;   ");
        }
    }
}

int size1 = Promt("Введите количество строк");
int size2 = Promt("Введите количество столбцов");
double[,] myArray = CreateArray(size1, size2);
PrintArray(myArray);