using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Forms
{
    public delegate void CambiarSubtotalInvoice();
    public partial class FormInvoiceDetail : Form
    {
        public event CambiarSubtotalInvoice OnCambiarSubTotalInvoice;
        List<Customer> ListCustomerType = new List<Customer>();
        public FormInvoiceDetail()
        {
            InitializeComponent();
            fillComboBox();
        }
        private void fillComboBox()
        {
            try
            {
                comboBoxCustomer.DataSource = ListCustomerType;
                comboBoxCustomer.DisplayMember = "CustName";
                comboBoxCustomer.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetInvoice(int idInvoice)
        { 
        
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OnCambiarSubTotalInvoice != null)
                {
                    OnCambiarSubTotalInvoice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
