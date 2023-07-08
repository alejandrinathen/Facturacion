using Facturacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                FormCliente form = new FormCliente();
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message + " " + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                FormInvoice formInvoice = new FormInvoice();
                formInvoice.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message+" "+ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
