internal class Program
{
    private static void Main(string[] args)
    {
        var answer = 0;

        try
        {
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
        catch (FormatException ex)
        {
            Console.WriteLine("Debe ingresar un numero, intente de nuevo.");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Error inesperado,favor intente de nuevo.");
        }
    }
}