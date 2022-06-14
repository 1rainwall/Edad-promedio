using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = Convert.ToInt32(txtbox_edad.Text);
                int prom = Convert.ToInt32(txtbox_prom.Text);

                if (edad == prom)
                {
                    MessageBox.Show("Las edades son iguales");

                    return;
                }

                if (edad > prom)
                {
                    MessageBox.Show("Edad mayor a la promedio");
                }
                else
                {
                    MessageBox.Show("Edad menor a la promedio");
                }

              }

            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, recuerda usar solo numeros");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbox_prom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
