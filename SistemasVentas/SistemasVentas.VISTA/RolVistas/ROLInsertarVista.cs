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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class ROLInsertarVista : Form
    {
        public ROLInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.nombre = textBox1.Text;
            r.estado = textBox2.Text;
            bss.InsertarRolBss(r);
            MessageBox.Show("Se guardo correctamente la rol");
        }
    }
}
