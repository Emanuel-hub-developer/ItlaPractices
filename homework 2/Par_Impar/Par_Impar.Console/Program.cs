internal class Program
{
    private static void Main(string[] args)
    {
        var answer = 0;

        Console.WriteLine("Ingrese un numero: ");
        answer = Convert.ToInt32(Console.ReadLine());

        if (answer % 2 == 0)
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar.");
        }
    }
}