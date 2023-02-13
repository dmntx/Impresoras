using System;
using System.Collections.Generic;
using System.Text;

namespace Impresoras
{
    /*interface IVolar
    {
        void Volar();
    }*/

   /*interface Venta
    {
        void Descuento();
    }*/

    public class Venta
    {
        public string impresora;
        public int total;
    }
    public class Descuentos
    {
        private estrategia estrategiaDescuento;
        private Venta venta;
        private double iva;

        public void ClienteFrecuente()
        {
            estrategiaDescuento = new SocioFrecuente();
        }
        public void Cliente5PorCiento()
        {
            estrategiaDescuento = new Cliente5Por();
        }

        public void NoDescuento()
        {
            estrategiaDescuento = new ClienteSinDescuento();
        }

        public void DescuentoFijo()
        {
            estrategiaDescuento = new ClienteFijo();
        }
    }

}
