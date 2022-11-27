Console.Clear();
Console.WriteLine("Enter first matrix size:");
int FirstMatrixRows = Convert.ToInt32(Console.ReadLine());
int FirstMatrixColumns = Convert.ToInt32(Console.ReadLine());
int[,] FirstMatrix = new int[FirstMatrixRows, FirstMatrixColumns];

Console.WriteLine("Enter second matrix size:");
int SecondMatrixRows = Convert.ToInt32(Console.ReadLine());
int SecondMatrixColumns = Convert.ToInt32(Console.ReadLine());
int[,] SecondMatrix = new int[SecondMatrixRows, SecondMatrixColumns];

int[,] FinalMatrix = new int[FirstMatrixRows, SecondMatrixColumns];

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

int[,] ProductOfMatrixs(int[,] FirstMatr, int[,] SecondMatr, int[,] FinalMatr, int FirstMatrRow, int SecondMatrColumn, int FirstMatrColumn, int SecondMatrRow)
{
    if (SecondMatrRow != FirstMatrColumn)
    {
        Console.WriteLine("Impossible");
    }
    
    
        for (int i = 0; i < FirstMatrRow; i++)
        {

            for (int j = 0; j < SecondMatrColumn; j++)
            {
                for (int k = 0; k < SecondMatrColumn; k++)
                {
                    FinalMatr[i, j] += FirstMatr[i, k] * SecondMatr[k, j];
                }

            }
        }
        return FinalMatr;
    }


FillArrayRandom(FirstMatrix);
FillArrayRandom(SecondMatrix);
PrintArray(FirstMatrix);
Console.WriteLine("*");
PrintArray(SecondMatrix);
Console.WriteLine("_________");
ProductOfMatrixs(FirstMatrix, SecondMatrix, FinalMatrix, FirstMatrixRows, SecondMatrixColumns, FirstMatrixColumns, SecondMatrixRows);
PrintArray(FinalMatrix);