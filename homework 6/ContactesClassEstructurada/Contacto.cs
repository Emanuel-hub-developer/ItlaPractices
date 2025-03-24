using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactesClassEstructurada
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Contacto(int id, string nombre, string telefono, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"{Id}    {Nombre}      {Telefono}      {Email}     {Direccion}");
        }
    }

    class Agenda
    {
        private List<Contacto> contactos = new List<Contacto>();
        private int contadorId = 1;

        public void AddContact()
        {
            Console.Write("Digite el Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Digite el Telefono: ");
            string telefono = Console.ReadLine();
            Console.Write("Digite el Email: ");
            string email = Console.ReadLine();
            Console.Write("Digite la direccion: ");
            string direccion = Console.ReadLine();

            contactos.Add(new Contacto(contadorId++, nombre, telefono, email, direccion));
            Console.WriteLine("Contacto agregado exitosamente.\n");
        }

        public void ContactHeader()
        {
            Console.WriteLine("Id           Nombre          Telefono            Email           Direccion");
            Console.WriteLine("___________________________________________________________________________");
        }

        public void ViewContacts()
        {
            ContactHeader();
            foreach (var contacto in contactos)
            {
                contacto.MostrarInfo();
            }
        }



        public void SearchContact()
        {
            Console.Write("Digite un Id de Contacto Para Mostrar: ");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            Contacto contacto = contactos.Find(c => c.Id == idSeleccionado);

            if (contacto != null)
            {
                ContactHeader();
                contacto.MostrarInfo();
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public void EditContact()
        {
            Console.Write("Digite un Id de Contacto Para Editar: ");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            Contacto contacto = contactos.Find(c => c.Id == idSeleccionado);

            if (contacto != null)
            {
                Console.Write("Nuevo Nombre: ");
                contacto.Nombre = Console.ReadLine();
                Console.Write("Nuevo Teléfono: ");
                contacto.Telefono = Console.ReadLine();
                Console.Write("Nuevo Email: ");
                contacto.Email = Console.ReadLine();
                Console.Write("Nueva Dirección: ");
                contacto.Direccion = Console.ReadLine();
                Console.WriteLine("Contacto editado correctamente.");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public void DeleteContact()
        {
            Console.Write("Digite un Id de Contacto Para Eliminar: ");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            Contacto contacto = contactos.Find(c => c.Id == idSeleccionado);

            if (contacto != null)
            {
                contactos.Remove(contacto);
                Console.WriteLine("Contacto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }

   
}
