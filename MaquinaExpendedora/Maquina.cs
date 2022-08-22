using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class Maquina
    {
        public static void Eleccion()
        {
            int A = 270, B = 340, C = 390;
            Productos.Class1 producto = new Productos.Class1();

            Console.WriteLine("Ingresa tu nombre: ");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Elije un producto");
            Console.WriteLine("1; A = $270");
            Console.WriteLine("2; B = $340");
            Console.WriteLine("3; C = $390");
            producto.N = int.Parse(Console.ReadLine());

            switch (producto.N)
            {
                case 1:

                    Console.WriteLine("Producto: A = 270");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("10= $10");
                    Console.WriteLine("50= $50");
                    Console.WriteLine("100= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda <= A)
                    {
                        producto.Faltante = A - producto.Moneda;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;

                case 2: 

                    Console.WriteLine("Producto: B = 340");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("1= $10");
                    Console.WriteLine("2= $50");
                    Console.WriteLine("3= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda <= B)
                    {
                        producto.Faltante = producto.Moneda - B;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;

                case 3:

                    Console.WriteLine("Producto: C = 390");
                    Console.WriteLine("Selecciona una moneda");
                    Console.WriteLine("1= $10");
                    Console.WriteLine("2= $50");
                    Console.WriteLine("3= $100");
                    producto.Moneda = int.Parse(Console.ReadLine());
                    while (producto.Moneda <= C)
                    {
                        producto.Faltante = producto.Moneda - C;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Faltante = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Faltante;

                    }
                    break;


            }

        }

       

        public static void Cambio()
        {
            int cant1 = 10, cant2 = 50, cant3 = 100, B100 = 0, B50 = 0, M10 = 0;

            Productos.Class1 producto = new Productos.Class1();

            if (producto.Moneda >= cant3)
            {
                B100 = (producto.Moneda / cant3);
                producto.Cambio = producto.Moneda - (B100 * 100);
            }
            if (producto.Moneda >= cant2)
            {
                B50 = (producto.Moneda / cant2);
                producto.Cambio = producto.Moneda - (B50 * 50);
            }
            if (producto.Moneda >= cant1)
            {
                M10 = (producto.Moneda / cant1);
                producto.Cambio = producto.Moneda - (M10 * 10);
            }

            Console.WriteLine("Su cambio" + producto.Nombre);
            Console.WriteLine("Billetes de 100: " + B100);
            Console.WriteLine("Billetes de 100: " + B50);
            Console.WriteLine("Billetes de 100: " + M10);

            Console.ReadKey();

        }
    }
}
