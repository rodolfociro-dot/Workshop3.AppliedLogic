namespace Shared
{
    public static class ConsoleExtension
    {
        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.Write(message);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;
            }
            return null;
        }

        public static object GetValidOptions(string v, object options)
        {
            throw new NotImplementedException();
        }
    }
}