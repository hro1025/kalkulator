using kalkulator;

public class Program
{
    static void Main(string[] args)
    {
        Kalkulator calc = new Kalkulator();

        int inputFirstNumberInt;
        double inputFirstNumberDouble;

        int inputSecondNumberInt;
        double inputSecondNumberDouble;

        while (true)
        {
            Console.Write("Skriv første tall: ");
            string? inputFirstNumber = Console.ReadLine();

            if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
            {
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

    public async Task Await()
    {
        var cli = new Cli();
        await cli.RunCli();
    }
}
