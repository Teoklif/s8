Console.Clear();
Console.WriteLine("Enter matrix size:");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayPerson(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"Enter number fot this position: ({i + 1};{j + 1})");
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void FillArrayRandom(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 11);
        }
    }
}

void FillArrauFromMaxToMin(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] <= matr[i, k]) continue;
                int temp = matr[i, j];
                matr[i, j] = matr[i, k];
                matr[i, k] = temp;
            }
    }
}

Console.Write("How do you want to fill array: Press 1 - fill by yourself, Press any other for filling random numbers.  ");
int button = Convert.ToInt32(Console.ReadLine());
if (button == 1)
{
    FillArrayPerson(matrix);

}
else
{
    FillArrayRandom(matrix);

}
PrintArray(matrix);

Console.WriteLine("--------");


FillArrauFromMaxToMin(matrix);

PrintArray(matrix);




