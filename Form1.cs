using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDatosPersonales
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "")
            {
                txt_Apellido.BackColor = Color.Red;
            }
            else
            {
                txt_Apellido.BackColor = System.Drawing.SystemColors.Control;
            }
            
            if (txt_Nombre.Text == "")
            {
                txt_Nombre.BackColor = Color.Red;
            }
            else
            {
                txt_Nombre.BackColor = System.Drawing.SystemColors.Control; 
            }

            if (txt_Edad.Text == "")
            {
                txt_Edad.BackColor = Color.Red;
            }
            else
            {
                txt_Edad.BackColor= System.Drawing.SystemColors.Control;
            }

            if (txt_Dir.Text == "")
            {
                txt_Dir.BackColor = Color.Red;
            }
            else
            {
                txt_Dir.BackColor= System.Drawing.SystemColors.Control;
            }
            string apellido = txt_Apellido.Text;
            string nombre = txt_Nombre.Text;
            string edad = txt_Edad.Text;
            string dir = txt_Dir.Text;
            lv_Result.Items.Clear();
            lv_Result.Items.Add(apellido);
            lv_Result.Items.Add(nombre);   
            lv_Result.Items.Add(edad);
            lv_Result.Items.Add(dir);

        }


        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //application.exit();
            this.Close();
        }
    }
}
