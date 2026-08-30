using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var m = ConsoleExtension.GetInt("Ingrese el valor de m: ");
    var n = ConsoleExtension.GetInt("Ingrese el valor de n: ");
    var p = ConsoleExtension.GetInt("Ingrese el valor de p: ");

    var matrixA = new int[m, n];
    var matrixB = new int[n, p];
    var matrixC = new int[m, p];

    FillMatrixA(matrixA);
    FillMatrixB(matrixB);
    MultiplyMatrices(matrixA, matrixB, matrixC);

    Console.WriteLine("*** A ***");
    ShowMatrix(matrixA);

    Console.WriteLine("*** B ***");
    ShowMatrix(matrixB);

    Console.WriteLine("*** C ***");
    ShowMatrix(matrixC);

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");

void FillMatrixA(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (i + 1) * j;
        }
    }
}

void FillMatrixB(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (j + 1) * i;
        }
    }
}

void MultiplyMatrices(
    int[,] matrixA,
    int[,] matrixB,
    int[,] matrixC)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] +=
                    matrixA[i, k] * matrixB[k, j];
            }
        }
    }
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}