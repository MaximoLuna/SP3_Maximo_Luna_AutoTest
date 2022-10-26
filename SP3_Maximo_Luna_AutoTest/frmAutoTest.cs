using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP3_Maximo_Luna_AutoTest
{
    public partial class frmAutoTest : Form
    {

        //Declaracion de variables globales (para este formulario)
        int numeroTurno;
        string nombreDominio;
        int añoFabricacion;
        string nombreTitular;

        //Declarar arrays
        //Vector - array 1 dimension
        string[] vecAutoTest = new string[5];
        //Matriz - array 2 dimensiones
        string[,] matAutoTest = new string[5, 10];

        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            numeroTurno = int.Parse(txtNumeroDeTurno.Text);
            nombreDominio = txtDominio.Text;
            añoFabricacion = Convert.ToInt32(NumAñoFabricacion.Value);
            nombreTitular = txtTitular.Text;

            MessageBox.Show("REGISTRO REALIZADO", "REGISTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            txtNumeroDeTurno.Clear();
            txtDominio.Clear();
            NumAñoFabricacion.Value = 2022;
            txtTitular.Clear();

            txtNumeroDeTurno.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numeroTurno + nombreTitular + nombreDominio + NumAñoFabricacion);
        }
        private void txtNumeroDeTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar))
        }
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); //Convierte a mayusculas
            }
            if (Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //Borra la tecla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
    }

