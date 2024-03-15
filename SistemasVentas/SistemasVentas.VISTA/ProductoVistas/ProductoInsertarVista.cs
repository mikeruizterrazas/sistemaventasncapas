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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
       ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.nombre = textBox1.Text;
            p.codigobarra = textBox2.Text;
            p.unidad = textBox3.TabIndex;
            p.descripcion = textBox4.Text;
            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardo correctamente la producto");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
