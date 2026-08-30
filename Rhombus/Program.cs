using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over.");