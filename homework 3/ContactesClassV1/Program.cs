using ContactesClassV1;
using System;
using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;

List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();



var people = new List<Person>();

while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada: ");

    try
    {
        int typeOption = Convert.ToInt32(Console.ReadLine());

        switch (typeOption)
        {
            case 1:
                {

                    AddContact(people);
                    Console.WriteLine("Contacto agregado!");

                }
                break;
            case 2: //extract this to a method
                {
                    PrintContactsHeader();
                    foreach (var item in people)
                    {
                        PrintIndividualContact(people, item.Id);
                    }

                }
                break;
            case 3: //search
                {
                    string nameCriterial;

                    Console.WriteLine("Ingrese el nombre del contacto que desea buscar:");
                    nameCriterial = Console.ReadLine();

                    var searchContact = people.Where(p => p.Name.ToLower().Contains(nameCriterial)).ToList();

                    foreach (var item in searchContact)
                    {
                        PrintContactsHeader();
                        PrintIndividualContact(searchContact, item.Id);
                    }

                }
                break;
            case 4: //modify
                {
                    bool run = true;
                    string contactModify;

                    Console.WriteLine("Ingrese el nombre del contacto que desea modificar:");
                    contactModify = Console.ReadLine();


                    var searchContact = people.Where(p => p.Name.ToLower().Contains(contactModify)).FirstOrDefault();

                    if (searchContact == null)
                    {
                        Console.WriteLine("El contacto ingresado no se encuentra en la lista de contactos");
                        break;
                    }

                    var contactExist = searchContact;
                    do
                    {
                        Console.WriteLine("Que desea modificar en el contacto?");
                        Console.WriteLine(@"1. Modificar Nombre     2. Modificar Apellido    3. Modificar Edad     4. Modificar Direccion   5. Modificar Telefono
                                 6. Modificar Email   7.Modificar si es mejor amigo");

                        Console.WriteLine("Digite el número de la opción deseada: ");
                        int typeModifyOption = Convert.ToInt32(Console.ReadLine());

                        switch (typeModifyOption)
                        {
                            case 1:
                                Console.WriteLine("Digite el nuevo nombre de la persona:");
                                contactExist.Name = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Digite el nuevo apellido de la persona:");
                                contactExist.LastName = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Digite la nueva edad de la persona en números:");
                                contactExist.Age = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 4:
                                Console.WriteLine("Digite la nueva dirección:");
                                contactExist.Address = Console.ReadLine();
                                break;

                            case 5:
                                Console.WriteLine("Digite el nuevo teléfono de la persona:");
                                contactExist.Phone = Console.ReadLine();
                                break;

                            case 6:
                                Console.WriteLine("Digite el nuevo email de la persona:");
                                contactExist.Email = Console.ReadLine();
                                break;

                            case 7:
                                Console.WriteLine("¿Es mejor amigo? 1. Sí, 2. No:");
                                string bestFriendInput = Console.ReadLine();
                                contactExist.isBestFriend = (bestFriendInput == "1");
                                break;

                            default:
                                Console.WriteLine("El número ingresado no es una opcion valida.");
                                return;
                        }
                     
                        Console.WriteLine("Desea modificar otra cosa del contacto? 1.Si 2.No");
                        var userAnswer = int.Parse(Console.ReadLine());
                        if(userAnswer == 1)
                        {
                            run = true;
                        }
                        else
                        {
                            run = false;
                        }

                    } while (run == true);

                    Console.WriteLine("Contacto modificado Exitosamente!");

                }
                break;
            case 5: //delete
                {
                    string contactDelete;

                    Console.WriteLine("Escriba el nombre del contacto que desea eliminar:");
                    contactDelete = Console.ReadLine();

                    var searchContact = people.Where(p => p.Name.ToLower().Contains(contactDelete)).FirstOrDefault();

                    if (searchContact == null)
                    {
                        Console.WriteLine("El contacto ingresado no se encuentra en la lista de contactos");
                        break;
                    }

                    people.Remove(searchContact);

                    Console.WriteLine("El contacto ha sido eliminado");

                }
                break;
            case 6:
                runing = false;
                break;
            default:
                Console.WriteLine("Tu eres o te haces el idiota?");
                break;
        }
    }
    catch
    {
        Console.WriteLine("no se aceptan caracteres en esta opcion bobo");
    }

        static void PrintIndividualContact(List<Person> people, int selectedId)
        {
            var person = people.FirstOrDefault(p => p.Id == selectedId);

        Console.WriteLine($"{person.Name}\t\t{person.LastName}\t\t{person.Address}\t\t{person.Phone}\t\t{person.Email}\t{person.Age}\t{person.IsBestFriendStr}");
        }
        static void PrintContactsHeader()
        {
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Nombre\t\tApellido\tDirección\t\tTeléfono\t\tEmail\t\tEdad\tMejor Amigo?");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
         }

    static void AddContact(List<Person> people)
    {
        Console.WriteLine("Digite el nombre de la persona");
        string name = Console.ReadLine();
        Console.WriteLine("Digite el apellido de la persona");
        string lastname = Console.ReadLine();
        Console.WriteLine("Digite la dirección");
        string address = Console.ReadLine();
        Console.WriteLine("Digite el telefono de la persona");
        string phone = Console.ReadLine();
        Console.WriteLine("Digite el email de la persona");
        string email = Console.ReadLine();
        Console.WriteLine("Digite la edad de la persona en números");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
        var isBestFriendOrNot = Convert.ToInt32(Console.ReadLine());


        var isBestFriend = (isBestFriendOrNot == 1) ? true : false;


        var id = people.Count;
        id++;

        var person = new Person
        {
            Id = id,
            Age = age,
            Email = email,
            Address = address,
            Name = name,
            LastName = lastname,
            Phone = phone,
            isBestFriend = isBestFriend
        };

        people.Add(person);


    }

    
}

