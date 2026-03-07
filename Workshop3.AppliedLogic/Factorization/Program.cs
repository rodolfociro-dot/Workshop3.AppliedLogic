
using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    {
        Console.Write("Ingrese el número a descomponer: ");
        int numero = int.Parse(Console.ReadLine()!);

        int divisor = 2;

        Console.Write( $"{numero} = ");

        while (numero > 1)
        {
            if (numero % divisor == 0)
            {
                Console.Write(divisor);
                numero = numero / divisor;

                if (numero > 1)
                {
                    Console.Write(" x ");
                }
            }
            else
            {
                divisor++;
            }
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
