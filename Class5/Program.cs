// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Ingrese el valor inicial: ");
            int valorInicial = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor final: ");
            int valorFinal = int.Parse(Console.ReadLine());

            Console.Write("Los números pares dentro del rango ingresado son: ");

            for (int i = valorInicial; i <= valorFinal; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

