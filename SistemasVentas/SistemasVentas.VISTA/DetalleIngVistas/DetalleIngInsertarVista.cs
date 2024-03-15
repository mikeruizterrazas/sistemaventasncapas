using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng d =new DetalleIng();
            d.fechavenc = DateTime.Today;
            d.cantidad = Convert.ToInt32(textBox2.Text);
            d.preciocosto = decimal.Parse(textBox3.Text);
            d.precioventa = decimal.Parse(textBox4.Text);
            d.subtotal =Convert.ToInt32(textBox5.Text);

            bss.InsertarDetalleIngBss(d);
            MessageBox.Show("se guardo de correctamente el detalleing");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
