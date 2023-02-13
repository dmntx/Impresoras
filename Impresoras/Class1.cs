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
        //public abstract void impresora(string impresora, int total);
    }
    public class SocioFrecuente : estrategia
    {
        public SocioFrecuente()
        {
        
        }
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.Write("Descuento por cliente frecuente");
            Console.WriteLine("Venta de producto: " + venta.impresora + "Por un total de: " + (venta.total + ((venta.total/100)*iva)));
            Console.WriteLine("Se aplicó un descuento del 50% por ser cliente frecuente");
            Console.WriteLine("Total con descuento aplicado: " + (venta.total + ((venta.total / 100) * iva)/2));
        }

        /*public void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }*/
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

        /*public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }*/
    }

    public class Cliente5Por : estrategia
    {
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.WriteLine("Descuento del 5 por ciento");
            venta.total = venta.total + ((venta.total / 100) * 16);
            Console.WriteLine("Venta de producto: " + venta.impresora + "Por un total de: " + (venta.total + ((venta.total / 100) * iva)));
            Console.WriteLine("Se aplicó un descuento del 5%");
            Console.WriteLine("Total con descuento aplicado: " + (venta.total - ((venta.total/100)*5)));
        }

        /*public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }*/
    }

    public class ClienteFijo : estrategia
    {
        public override void aplicarDescuento(Venta venta, double iva)
        {
            Console.WriteLine("Descuento del $100 por su compra");
        }

        /*public override void impresora(string impresora, int total)
        {
            venta.impresora = impresora;
            venta.total = total;
        }*/
    }
}

