using kalkulator;

public class Program
{
    public static void Main(string[] args)
    {
        Cli cli = new Cli();
        // Here is the input safed
        int inputFirstNumberInt = 0;
        double inputFirstNumberDouble = 0;

        int inputSecondNumberInt = 0;
        double inputSecondNumberDouble = 0;

        bool useInt; // i use bool to say what kind of input it is (int / double)

        // first input in a loop
        while (true)
        {
            Console.Write("Skriv første tall: ");
            string? inputFirstNumber = Console.ReadLine();

            if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
            {
                useInt = true;
                break;
            }
            else if (double.TryParse(inputFirstNumber, out inputFirstNumberDouble))
            {
                useInt = false;
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }
        // second input in a loop
        while (true)
        {
            Console.Write("Skriv andre tall: ");
            string? inputSecondNumber = Console.ReadLine();

            if (useInt && int.TryParse(inputSecondNumber, out inputSecondNumberInt))
            {
                break;
            }
            else if (!useInt && double.TryParse(inputSecondNumber, out inputSecondNumberDouble))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }
        // program sends the value over to Cli
        if (useInt)
        {
            cli.UseInt = true;

            cli.FirstNumberInt = inputFirstNumberInt;
            cli.SecondNumberInt = inputSecondNumberInt;
        }
        else
        {
            cli.UseInt = false;
            cli.FirstNumberDouble = inputFirstNumberDouble;
            cli.SecondNumberDouble = inputSecondNumberDouble;
        }

        cli.RunCli();
    }
}
