using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine()!);


        int sume = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int value = i + 1;

            // First column
            Console.Write(value + "\t");
            sume += value;

            if (value > max) max = value;
            if (value < min) min = value;

            // Other columns
            for (int j = 1; j < n; j++)
            {
                value = i + 1 - j;

                Console.Write(value + "\t");

                sume += value;

                if (value > max) max = value;
                if (value < min) min = value;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"La sumatoria es:    {sume}");
        Console.WriteLine($"El valor máximo es: {max}");
        Console.WriteLine($"El valor mínimo es: {min}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
