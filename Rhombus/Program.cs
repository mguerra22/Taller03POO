using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var size = ConsoleExtension.GetInt("Ingrese el tamaño del rombo: ");

    ShowRhombus(size);

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ",options);
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer,StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s",StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");

void ShowRhombus(int size)
{
    for (int i = 1; i <= size; i += 2)
    {
        ShowLine(i, size);
    }

    for (int i = size - 2; i >= 1; i -= 2)
    {
        ShowLine(i, size);
    }
}

void ShowLine(int numberOfHashes, int size)
{
    var spaces = (size - numberOfHashes) / 2;

    for (int i = 0; i < spaces; i++)
    {
        Console.Write(" ");
    }

    if (numberOfHashes == 1)
    {
        Console.Write("#");
    }
    else
    {
        Console.Write("#");

        for (int i = 0; i < numberOfHashes - 2; i++)
        {
            Console.Write(" ");
        }

        Console.Write("#");
    }

    Console.WriteLine();
}