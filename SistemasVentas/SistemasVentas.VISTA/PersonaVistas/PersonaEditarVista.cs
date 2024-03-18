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
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss =new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObteneridBss(idx);
            textBox1.Text = p.nombre;
            textBox2.Text = p.apellido;
            textBox3.Text = p.telefono;
            textBox4.Text = p.ci;
            textBox5.Text = p.correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.nombre= textBox1.Text;
            p.apellido=textBox2.Text;
            p.telefono = textBox3.Text;
            p.ci= textBox4.Text;
            p.correo = textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("datos actualizado");
        }
    }
}
