using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //estre programa imprimira la tabla de multiplicar del numero que digite 
            Console.WriteLine("==================================");
            Console.WriteLine("Programa que muestra la tabla de multipicación");
            int x;

            for (x = 1; x <= 5; x = x + 1)
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("Ingrese el numero al que quiere ver la tabla de multiplicar");
                int Num = Convert.ToInt32(Console.ReadLine());

                int R1 = Num * 1;
                Console.WriteLine(Num + " * 1 =" + R1);
                int R2 = Num * 2;
                Console.WriteLine(Num + " * 2 =" + R2);
                int R3 = Num * 3;
                Console.WriteLine(Num + " * 3 =" + R3);
                int R4 = Num * 4;
                Console.WriteLine(Num + " * 4 =" + R4);
                int R5 = Num * 5;
                Console.WriteLine(Num + " * 5 =" + R5);
                int R6 = Num * 6;
                Console.WriteLine(Num + " * 6 =" + R6);
                int R7 = Num * 7;
                Console.WriteLine(Num + " * 7 =" + R7);
                int R8 = Num * 8;
                Console.WriteLine(Num + " * 8 =" + R8);
                int R9 = Num * 9;
                Console.WriteLine(Num + " * 9 =" + R9);
                int R10 = Num * 10;
                Console.WriteLine(Num + " * 10 =" + R10);
                Console.WriteLine("Presiona ENTER");
                Console.WriteLine("==============================================================");
            }
            Console.WriteLine("Saliendo del programa -------->");
            Console.ReadKey();
        }
    }
}
