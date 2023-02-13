using System;
using System.Collections.Generic;
using System.Text;

namespace Impresoras

{
    class programa
    {
        static void Main(string[] args)
        {
            estrategia Cliente1;
            estrategia Cliente2;
            estrategia Cliente3;
            estrategia Cliente4;
            Venta venta1 = new Venta();
            venta1.impresora = "Lexmar";
            venta1.total = 10500;
            Venta venta2 = new Venta();
            venta2.impresora = "Hp Deskjet";
            venta2.total = 10340;

            Cliente1 = new Cliente5Por();
            Cliente2 = new ClienteFijo();
            Cliente3 = new ClienteSinDescuento();
            Cliente4 = new ClienteSinDescuento();
            Cliente1.aplicarDescuento(venta1, 16);
            Cliente2.aplicarDescuento(venta2,16);
            Console.ReadKey();
        }
    }
}
