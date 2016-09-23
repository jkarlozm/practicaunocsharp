using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prac1Vendedor.Vendedor pra1 = new Prac1Vendedor.Vendedor(System.Convert.ToInt32(Reg.Text), 
                Nom.Text, System.Convert.ToInt32(Age.Text), Mail.Text);
            pra1.Obtenerv1(System.Convert.ToInt32(m1.Text),
            System.Convert.ToInt32(a1.Text),
            System.Convert.ToSingle(vv1.Text),
            s1.Text);
            pra1.Obtenerv2(System.Convert.ToInt32(m2.Text),
                System.Convert.ToInt32(a2.Text),
                System.Convert.ToSingle(vv2.Text),
                s2.Text);
            MessageBox.Show(pra1.MostrarVendedor());
        }
    }
}
