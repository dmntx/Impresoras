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

            Cliente1 = new Cliente5Por();
            Cliente2 = new ClienteFijo();
            Cliente3 = new ClienteSinDescuento();
            Cliente4 = new ClienteSinDescuento();
            Cliente1.impresora("Lexmar", 300);
            Cliente2.impresora("Hp", 500);
            Cliente1.aplicarDescuento();
            Cliente2.aplicarDescuento();
        }
    }
}
