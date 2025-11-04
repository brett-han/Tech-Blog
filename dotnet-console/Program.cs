using System.Globalization;
using dotnet_console;

class Program
{
    static void Main()
    {
        var calc = new Calculator();
        Console.WriteLine("Calculator (type q to quit)");
        while (true)
        {
            Console.Write("Enter: <number> <op> <number>  e.g., 12 + 3 : ");
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line.Trim().Equals("q", StringComparison.OrdinalIgnoreCase)) break;

            try
            {
                var inv = CultureInfo.InvariantCulture;
                var tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3) throw new ArgumentException("Use: <number> <op> <number>");

                double a = double.Parse(tokens[0], inv);
                string op = tokens[1];
                double b = double.Parse(tokens[2], inv);

                double result = op switch
                {
                    "+" => calc.Add(a, b),
                    "-" => calc.Subtract(a, b),
                    "*" or "x" => calc.Multiply(a, b),
                    "/" => calc.Divide(a, b),
                    "^" => calc.Pow(a, b),
                    _ => throw new ArgumentException("Supported ops: +  -  *  /  ^")
                };

                Console.WriteLine($"= {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}