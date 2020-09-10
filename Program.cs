using System;

namespace Ejercicios_P_lll {
    class Program {
        
        static void Main(string[] args) {
            int opcion = 0;
            
            do {
                Console.Clear();
                Menu(ref opcion);

                switch (opcion) {
                    case 1:
                        Ejercicio1();
                    break;

                    case 2:
                        Ejercicio2();
                    break;

                    case 3:
                        Ejercicio3();
                    break;
                }
            } while (opcion != 0);
        }

        static void Menu(ref int opcion) {
            
            Console.WriteLine("Menu");
            Console.WriteLine("\n1. Ejercicio 1.");
            Console.WriteLine("2. Ejericio 2.");
            Console.WriteLine("3. Ejericio 3.");
            Console.WriteLine("0. Salir.");
            Console.Write("\nOPCION: ");
            opcion = int.Parse(Console.ReadLine());
        }

        static void Ejercicio1() {
            float nota, sumaDeNotas = 0;

            for (int i = 1; i <= 3; i++) {
                Console.Write($"Ingrese la nota #{i}: ");
                nota = float.Parse(Console.ReadLine());

                sumaDeNotas += nota;
            }

            float Promedio = sumaDeNotas / 3;

            if(Promedio >= 3) {
                Console.WriteLine("\n¡Usted Ganó la asignatura!.");
                
            } else {
                Console.WriteLine("\nUsted perdió la asignatura.");
            }

            Console.WriteLine("\nPresione enter para continuar...");
            Console.ReadKey();
        }

        static void Ejercicio2() {
            int edad;
            char sexo;
            do {
                Console.Write("Ingrese su sexo[H/M]: ");
                sexo = Char.ToUpper(char.Parse(Console.ReadLine()));

                if(sexo != 'H' && sexo != 'M') {
                    Console.WriteLine("Solo puede digitar H o M.");
                    Console.ReadKey();
                }
            } while (sexo != 'H' && sexo != 'M');
            
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            float pulsacion;
            if(sexo == 'H') {
                pulsacion = 210 - edad;
            } else {
                pulsacion = 220 - edad;
            }
            
            Console.WriteLine($"Su pulsacion cada 10 segundos debe ser de: {pulsacion / 10}");
            Console.ReadKey();
        }

        static void Ejercicio3() {
            String nombre, numeroCuenta;
            float saldo;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese numero de cuenta: ");
            numeroCuenta = Console.ReadLine();
            Console.Write("Ingrese saldo inicial: ");
            saldo = float.Parse(Console.ReadLine());

            int opcionMenuCuenta = 0;
            do {
                
                Console.Clear();
                Console.WriteLine($"Nombre: {nombre} No Cuenta: {numeroCuenta} saldo: {saldo}");
                Console.WriteLine("\n1. Consignar.");
                Console.WriteLine("2. Retirar.");
                Console.WriteLine("0. Cancelar.");
                Console.Write("\nOPCION: ");
                opcionMenuCuenta = int.Parse(Console.ReadLine());

                switch (opcionMenuCuenta) {
                    case 1:
                        Console.Write("Cuanto desea consignar?: ");
                        float valorConsignado = float.Parse(Console.ReadLine());

                        saldo += valorConsignado; 
                    break;

                    case 2:

                        Console.Write("Cuanto desea retirar?");
                        float valorRetirado = float.Parse(Console.ReadLine());

                        if(valorRetirado > saldo) {
                            Console.WriteLine("Usted no tiene saldo suficiente para retirar.");
                            Console.ReadKey();
                        } else {
                            saldo -= valorRetirado;
                        }
                    break;
                }
            } while (opcionMenuCuenta != 0);
            



        }
    }
}
