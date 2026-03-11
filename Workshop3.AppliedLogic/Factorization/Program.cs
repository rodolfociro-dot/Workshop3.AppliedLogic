
using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    {
        Console.Write("Ingrese el número a descomponer: ");
        int numero = int.Parse(Console.ReadLine()!);

        int divider = 2;

        Console.Write( $"{number} = ");

        while (number > 1)
        {
            if (number % divider == 0)
            {
                Console.Write(divisor);
                number = number / divider;

                if (number > 1)
                {
                    Console.Write(" x ");
                }
            }
            else
            {
                divider++;
            }
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
