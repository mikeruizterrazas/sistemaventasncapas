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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVenraInsertarVista : Form
    {
        public DetalleVenraInsertarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.cantidad = textBox1.Text;
            d.precioventa = Convert.ToInt64(textBox2);
            d.subtotal = Convert.ToInt64(textBox4);
            
            bss.InsertarDetalleVentaBss(d);
            MessageBox.Show("se guardo de correctamente el detalleing");
        }
    }
}

