using kalkulator;

public class Program
{
    static void Main(string[] args)
    {
        Kalkulator calc = new Kalkulator();

        int inputFirstNumberInt = Cli.;
        double inputFirstNumberDouble;

        int inputSecondNumberInt;
        double inputSecondNumberDouble;

        while (true)
        {
            Console.Write("Skriv første tall: ");
            string? inputFirstNumber = Console.ReadLine();

            if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
            {
                inputFirstNumberDouble = inputFirstNumberInt;
                break;
            }
            else if (double.TryParse(inputFirstNumber, out inputFirstNumberDouble))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }

        while (true)
        {
            Console.Write("Skriv andre tall: ");
            string? inputSecondNumber = Console.ReadLine();

            if (int.TryParse(inputSecondNumber, out inputSecondNumberInt))
            {
                inputSecondNumberDouble = inputSecondNumberInt;

                break;
            }
            else if (double.TryParse(inputSecondNumber, out inputSecondNumberDouble))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }
    }

    public static async Task Main()
    {
        var cli = new Cli();
        await cli.RunCli();
    }
}
