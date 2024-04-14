using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_numero_1
{

    public class Calculadora
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede divir por el número 0.");
            }
            return a / b;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Raiz(double a)
        {
            return Math.Sqrt(a);
        }

        public double Modulo(double a, double b)
        {
            return a % b;
        }

        public double Logaritmo(double a, double newBase)
        {
            return Math.Log(a, newBase);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();

            Console.WriteLine("Calculadora");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Módulo");
            Console.WriteLine("8. Logaritmo");
            Console.WriteLine("9. Salir");

            while (true)
            {
                Console.Write("Seleccione una operación: ");
                string opcionStr = Console.ReadLine();
                int opcion;
                if (!int.TryParse(opcionStr, out opcion))
                {
                    Console.WriteLine("Introduce un número del 1 al 9.");
                    continue;
                }

                double resultado;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Sumar(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Restar(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Multiplicar(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 4:
                        Console.Write("Ingrese el dividendo: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Dividir(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 5:
                        Console.Write("Ingrese la base: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el exponente: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Potencia(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 6:
                        Console.Write("Ingrese el número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Raiz(num1);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 7:
                        Console.Write("Ingrese el dividendo: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Modulo(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 8:
                        Console.Write("Ingrese el número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la base del logaritmo: ");
                        double newBase = Convert.ToDouble(Console.ReadLine());
                        resultado = calculadoraCientifica.Logaritmo(num1, newBase);
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 9:
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Ingrese un número del 1 al 9.");
                        break;
                }
            }
        }
    }
}