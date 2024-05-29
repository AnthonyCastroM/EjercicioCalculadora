using System;
using System.Threading;

namespace EjercicioEnClase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;
            string opcion = "";

            //MENU
            void menu()
            {
                Console.Write("======================== MENU ========================\n1- Sumar\n2- Restar\n3- Division\n4- Multiplicacion \n5- Potencia\n6- Area triangulo\n7- Area cuadrado\n8- Salir \nEscriba la operacion que desea realizar: ");
                opcion = Console.ReadLine().Trim().ToLower();
            }



            while (opcion != "salir")
            {
                switch (opcion)
                {
                    case "sumar":
                        Console.Write("Ingrese el primer numero: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el segundo numero: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = numero1 + numero2;

                        break;
                    case "restar":
                        Console.Write("Ingrese el primer numero: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el segundo numero: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = numero1 - numero2;

                        break;
                    case "division":
                        Console.Write("Ingrese el primer numero: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el segundo numero: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = numero1 / numero2;

                        break;
                    case "multiplicacion":
                        Console.Write("Ingrese el primer numero: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el segundo numero: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = numero1 * numero2;

                        break;
                    case "potencia":
                        Console.Write("Ingrese la base: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el exponente: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = (int)Math.Pow(numero1, numero2);

                        break;
                    case "area triangulo":
                        Console.Write("Ingrese el valor de un lado: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        numero2 = numero1;

                        resultado = (numero1 * numero2) / 2;

                        break;
                    case "area cuadrado":
                        Console.Write("Ingrese el valor de la base: ");
                        int.TryParse(Console.ReadLine(), out numero1);
                        Console.Write("Ingrese el valor de la altura: ");
                        int.TryParse(Console.ReadLine(), out numero2);

                        resultado = numero1 * numero2;

                        break;
                    case "salir":
                        break;
                }
                Console.WriteLine("Resultado: " + resultado);
                Thread.Sleep(3000); // Pausar la ejecución durante el tiempo especificado

                Console.Clear();
                menu();
            }
        }
    }
}
