using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class Maquina
    {
        public static int Eleccion()
        {
            int A = 270, B = 340, C = 390 ,Total = 0 ;

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
                    while (producto.Moneda < A)
                    {
                        producto.Faltante = A - producto.Moneda;
                        Console.WriteLine("Falta dinero, Ingresa el faltante = " + producto.Faltante);
                        producto.Falta = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Falta;

                        Total = producto.Moneda - 270;

                    }
                    return Total;
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
                        producto.Falta = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Falta;

                        Total = producto.Moneda - 340;

                    }
                    return Total;
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
                        producto.Falta = int.Parse(Console.ReadLine());
                        producto.Moneda = producto.Moneda + producto.Falta;
                        Total = producto.Moneda - 390;


                    }
                    return Total;
                    break;

                    
            }
            return Total;

        }



        public static void Cambio(int Total)
        {
            int  B50 = 50, M10 = 10;

            while (Total > 0)
            {
                if (Total >= 50)
                {
                    Console.WriteLine("Se entrega billete de $50");
                    Total = Total - B50;

                }
                else
                {
                    Console.WriteLine("Se entrega una moneda de $10");
                    Total = Total - M10;
                    
                }
            }
            

        }
    }
}
