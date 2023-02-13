using System;
using System.Collections.Generic;
using System.Text;

namespace Impresoras
{
    public abstract class estrategia
    {
        protected double iva;
        protected Venta venta;

        public estrategia()
        {
            
        }
        public abstract void aplicarDescuento(Venta venta, double iva);
        public abstract void impresora(string impresora, int total);
    }
    public class SocioFrecuente : estrategia
    {
        public SocioFrecuente()
        {
      
        }
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.Write("Descuento por cliente frecuente");
        }

        public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }
    }

    public class ClienteSinDescuento : estrategia
    {
        public ClienteSinDescuento()
        {

        }
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.WriteLine("Cliente sin descuento");
        }

        public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }
    }

    public class Cliente5Por : estrategia
    {
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.WriteLine("Descuento del 5 por ciento");
        }

        public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }
    }

    public class ClienteFijo : estrategia
    {
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.WriteLine("Descuento del $100 por su compra");
        }

        public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }
    }
}

