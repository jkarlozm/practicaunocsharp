using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac1Vendedor
{
    public class Vendedor
    {
        public int registro { set; get; }
        public string nombre { set; get; }
        public int edad { set; get; }
        public string correo { set; get; }

        //invocacion de clase venta
        Prac1venta.Venta v1 = new Prac1venta.Venta();
        Prac1venta.Venta v2 = new Prac1venta.Venta();

        public void Obtenerv1(int m, int a, float vv, string s)
        {
            v1.Mes = m;
            v1.Año = a;
            v1.ventavendida = vv;
            v1.supervisor = s;
        }

        public void Obtenerv2(int m, int a, float vv, string s)
        {
            v2.Mes = m;
            v2.Año = a;
            v2.ventavendida = vv;
            v2.supervisor = s;
        }

        //constructor vacio
        public Vendedor()
        { 
        }

        //constrcutor de inicializacion
        public Vendedor(int _reg, string _nom, int _dad, string _rreo)
        {
            registro = _reg;
            nombre = _nom;
            edad = _dad;
            correo = _rreo;
        }

        public string MostrarVendedor()
        {
            string vend = "";
            vend = "Datos Vendedor: " + "\n" + "\n" + "Registro: " + registro + "\nNombre: " + nombre +
                "\nEdad: " + edad + "\nCorreo: " + correo;
            vend = vend + v1.MostrarDatos() + "\n" + v2.MostrarDatos();
            return vend;
        }
    }
}
