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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
           Persona p = new Persona();
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text;
            p.telefono = textBox3.Text;
            p.ci = textBox4.Text;
            p.correo = textBox5.Text;

            bss.InsertarPersonaBss(p);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PersonaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
