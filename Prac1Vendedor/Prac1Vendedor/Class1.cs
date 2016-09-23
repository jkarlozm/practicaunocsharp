using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac1Vendedor
{
    public class Vendedor
    {
        //  Atributos del vendedor.
        public int registro { set; get; }
        public string nombre { set; get; }
        public int edad { set; get; }
        public string correo { set; get; }

        //  Invocación de clase venta
        Prac1venta.Venta v1 = new Prac1venta.Venta();
        Prac1venta.Venta v2 = new Prac1venta.Venta();

        //  Métodos de la clase venta para obtener y almacenar los valores de venta uno y venta dos.
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

        //  Constructor vacio.
        public Vendedor()
        { 
        }

        //  Constrcutor de inicialización.
        public Vendedor(int _reg, string _nom, int _dad, string _rreo)
        {
            registro = _reg;
            nombre = _nom;
            edad = _dad;
            correo = _rreo;
        }

        //  Método que muestra los datos almacenados en los atributos de vendedor y venta.
        public string MostrarVendedor()
        {
            string vend = "";
            //  Datos vendedor
            vend = "Datos Vendedor: " + "\n" + "\n" + "Registro: " + registro + "\nNombre: " + nombre + "\nEdad: " + edad + "\nCorreo: " + correo + "\n";
            
            //  Datos venta accesando al método MostarVenta.
            vend = vend + v1.MostrarVenta() + "\n" + v2.MostrarVenta();            
            return vend;
        }
    }
}
