using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista2 : Form
    {
        public UsuarioInsertarVista2()
        {
            InitializeComponent();
        }
        public static int idpersonaseleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr =new PersonaListarVista();    
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObteneridBss(idpersonaseleccionada);
                textBox1.Text = persona.nombre + " " + persona.apellido;
            }
           
        }
        UsuarioBss bssuser = new UsuarioBss();
        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.idpersona = idpersonaseleccionada;
            usuario.nombreuser = textBox2.Text;
            usuario.contraseña = textBox3.Text;
            usuario.fechareg = dateTimePicker1.Value;

            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("usuario registrado");
        }

    }
}
