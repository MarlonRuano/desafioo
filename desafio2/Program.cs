using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    public interface INotificable
    {
        void Notificar(string mensaje);
    }

    public class NotificacionEmail : INotificable
    {
        public string DireccionCorreo { get; set; }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando email a {DireccionCorreo}: {mensaje}");
        }
    }

    public class NotificacionWhatsapp : INotificable
    {
        public string NumeroTelefono { get; set; }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"se esta enviando mensaje de WhatsApp al número {NumeroTelefono}: {mensaje}");
        }
    }

    public class NotificacionSMS : INotificable
    {
        public string NumeroTelefono { get; set; }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje al número {NumeroTelefono}: {mensaje}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una notificación:");
                Console.WriteLine("1. Email");
                Console.WriteLine("2. WhatsApp");
                Console.WriteLine("3. SMS");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcionStr = Console.ReadLine();
                int opcion;
                if (!int.TryParse(opcionStr, out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Introduce un numero del 1 al 4.");
                    continue;
                }

                if (opcion == 4)
                {
                    Console.WriteLine("Saliendo.");
                    return;
                }

                Console.Write("Introduzca el mensaje: ");
                string mensaje = Console.ReadLine();

                INotificable notificacion;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el correo electrónico: ");
                        string correo = Console.ReadLine();
                        notificacion = new NotificacionEmail { DireccionCorreo = correo };
                        break;
                    case 2:
                        Console.Write("Ingrese el número de teléfono de WhatsApp: ");
                        string whatsapp = Console.ReadLine();
                        notificacion = new NotificacionWhatsapp { NumeroTelefono = whatsapp };
                        break;
                    case 3:
                        Console.Write("Ingrese el número de teléfono para enviar SMS: ");
                        string telefono = Console.ReadLine();
                        notificacion = new NotificacionSMS { NumeroTelefono = telefono };
                        break;
                    default:
                        throw new InvalidOperationException("Introduce un numero del 1 al 4.");
                }

                notificacion.Notificar(mensaje);
            }
        }
    }
}