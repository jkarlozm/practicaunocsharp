using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac1venta
{
    public class Venta
    {
        public int Mes { set; get; }
        public int Año { set; get; }
        public float ventavendida { set; get; }
        public string supervisor { set; get; }

        //constructor vacio
        public Venta()
        { 
        }

        //contructor de inicializacion
        public Venta(int _m, int _a, float _vv, string _namesuper)
        {
            Mes = _m;
            Año = _a;
            ventavendida = _vv;
            supervisor = _namesuper;
        }

        public string MostrarVenta()
        {
            string vent = "";
            vent = "/n" + "/nDatos Venta: " + "\n" + "\n Mes: " + Mes + "\nAño: " + Año +
                "\nVenta Vendida: " + ventavendida + "\nSupervisor: " + supervisor;
            return vent;
        }
    }
}
