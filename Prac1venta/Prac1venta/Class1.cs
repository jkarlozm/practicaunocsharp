using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac1venta
{
    public class Venta
    {
        //  Atributos de la venta.
        public int Mes { set; get; }
        public int Año { set; get; }
        public float ventavendida { set; get; }
        public string supervisor { set; get; }

        //  Constructor vacio.
        public Venta()
        { 
        }

        //  Contructor de inicialización.
        public Venta(int _m, int _a, float _vv, string _namesuper)
        {
            Mes = _m;
            Año = _a;
            ventavendida = _vv;
            supervisor = _namesuper;
        }

        //  Método que muestra en pantalla los valores almacenados en los atributos de venta.
        public string MostrarVenta()
        {
            string vent = "";
            vent = "\n" + "Datos Venta: " + "\n" + "\nMes: " + Mes + "\nAño: " + Año +
                "\nVenta Vendida: " + ventavendida + "\nSupervisor: " + supervisor;
            return vent;
        }
    }
}
