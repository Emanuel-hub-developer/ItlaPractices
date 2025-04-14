using ContactesClassEstructurada;
using System.Linq.Expressions;

Console.WriteLine("Mi Agenda Perrón");

Console.WriteLine("Bienvenido a tu lista de contactes");

Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> phones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
List<string> addresses = new List<string>();
List<int> ids = new List<int>();

Agenda agenda = new Agenda();
bool runing = true;
int choice = 0;

    while (runing)
    {
    
        Console.WriteLine("1. Agregar Contacto   2. Ver Contactos   3. Buscar Contacto");
        Console.WriteLine("4. Modificar Contacto   5. Eliminar Contacto   6. Salir");
        Console.Write("Elige una opcion: ");

    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Bobo debes ingresar un numero.");
    }

    try
    {
        switch (choice)
        {
            case 1:
                agenda.AddContact();
                break;
            case 2:
                agenda.ViewContacts();
                break;
            case 3:
                agenda.SearchContact();
                break;
            case 4:
                agenda.EditContact();
                break;
            case 5:
                agenda.DeleteContact();
                break;
            case 6:
                runing = false;
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }catch (Exception ex)
    {
        Console.WriteLine($"Ha sucedido un error en la agenda: {ex.Message}");
    }
    }

    