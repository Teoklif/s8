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

int[] MatrixRowsSum(int[,] matr, int number)
{
    int sum = 0;
    int[] array = new int[number];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        int j = 0;
        while (j < matr.GetLength(1))
        {

            sum = sum + matr[i, j];
            j++;

        }
        array[i] = sum;


    }
    return array;
}

void MaxMatrixRows(int[] array)
{
    int max = 0;
    int i = 0;
    while (i < array.GetLength(0))

    {
        for (int j = 0; j < array.GetLength(0); j++)

        {
            if (array[max] < array[i])
            {
                max = i;
            }

        }
        i++;
    }
    Console.WriteLine($"max = {array[max]}");
    Console.WriteLine($"строка № {i}");
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
int[] SumArray = MatrixRowsSum(matrix, rows);
MaxMatrixRows(SumArray);


