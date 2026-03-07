using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine()!);


        int suma = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int valor = i + 1;

            // First column
            Console.Write(valor + "\t");
            suma += valor;

            if (valor > max) max = valor;
            if (valor < min) min = valor;

            // Demás columnas
            for (int j = 1; j < n; j++)
            {
                valor = i + 1 - j;

                Console.Write(valor + "\t");

                suma += valor;

                if (valor > max) max = valor;
                if (valor < min) min = valor;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"La sumatoria es:    {suma}");
        Console.WriteLine($"El valor máximo es: {max}");
        Console.WriteLine($"El valor mínimo es: {min}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
