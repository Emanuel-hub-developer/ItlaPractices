using Calculator;

Calculadora calc = new Calculadora();
bool running = true;
int option = 0;

Console.WriteLine("This is the best calculator");

while (running)
{
    calc.DisplayHeader();

    try
    {
        option = Convert.ToInt32(Console.ReadLine());

        if (option == 5)
        {
            running = false;
            continue;
        }

        calc.ClearNumbers();

        Console.WriteLine("Please Type the first number");
        calc.AddNumber(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Please Type the second number");
        calc.AddNumber(Convert.ToDecimal(Console.ReadLine()));

        int wantToContinue = 0;
        while (wantToContinue != 2)
        {
            Console.WriteLine("Do you want to continue inserting numbers? 1. Yes, 2. No");
            wantToContinue = Convert.ToInt32(Console.ReadLine());
            if (wantToContinue == 1)
            {
                Console.WriteLine("Please Type another number");
                calc.AddNumber(Convert.ToDecimal(Console.ReadLine()));
            }
        }

        decimal result = 0;
        switch (option)
        {
            case 1:
                result = calc.Sum();
                break;
            case 2:
                result = calc.Subtract();
                break;
            case 3:
                result = calc.Multiply();
                break;
            case 4:
                result = calc.Divide();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }

        Console.WriteLine($"The Result of the operation is: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by zero: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Closing DB Connection");
    }
}