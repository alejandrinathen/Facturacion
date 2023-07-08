using BusinessObject.Interfaces;
using BusinessObject.Models;
using BusinessObject.Repository;
using BusinessObject.Services;
using Facturacion.UserControls;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facturacion.Forms
{
    public partial class FormInvoice : Form, IInvoice
    {
        private MyContext _context;
        private InvoicePresenter _presenter;
 
        UserControlInvoiceDetail userControlInvoice;
        public FormInvoice()
        {
            InitializeComponent();
            _context = new MyContext("Test_Invoice");
            _presenter = new InvoicePresenter(_context, this);
            fillComboBox();
            userControlInvoice = new UserControlInvoiceDetail();
            userControlInvoice.SetInvoice(Id);

            userControlInvoice.OnCambiarSubTotalInvoice += UserControlInvoice_OnCambiarSubTotalInvoice;
        }

        private void UserControlInvoice_OnCambiarSubTotalInvoice()
        {
            _presenter.SumarizarDetalle();
            buttonSalvar_Click(null, null);

        }

        private void fillComboBox()
        {
            try
            {
                comboBoxCustomer.DataSource = _context.Customer.ToList();
                comboBoxCustomer.DisplayMember = "CustName";
                comboBoxCustomer.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Properties
        private int _Id;
        public int Id
        {
            get
            {
                int.TryParse(textBoxId.Text, out _Id);
                if (_Id == 0)
                    textBoxId.Text = "0";
                return _Id;
            }
            set
            {
                textBoxId.Text = value.ToString();
            }
        }
        public int CustomerId
        {
            get
            {
                return Convert.ToInt32(comboBoxCustomer.SelectedValue);
            }

            set
            {
                comboBoxCustomer.SelectedValue = value;
            }
        }
        public decimal TotalItbis
        {
            get
            {
                return numericUpDownTotalItbis.Value;
            }

            set
            {
                numericUpDownTotalItbis.Value = value;
            }
        }
        public decimal SubTotal {
            get
            {
                return numericUpDownSubTotal.Value;
            }

            set
            {
                numericUpDownSubTotal.Value = value;
            }
        }
        public decimal Total {
            get
            {
                return numericUpDownTotal.Value;
            }

            set
            {
                numericUpDownTotal.Value = value;
            }
        }

        #endregion

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                userControlInvoice = new UserControlInvoiceDetail();
                panel.Controls.Add(userControlInvoice);
                panel.Dock = DockStyle.Bottom;
                userControlInvoice.SetInvoice(Id);
                userControlInvoice.OnCambiarSubTotalInvoice += UserControlInvoice_OnCambiarSubTotalInvoice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerId < 1)
                {
                    errorProvider.SetError(this.comboBoxCustomer, "No se puede dejar vacio");
                    return;
                }
                _presenter.Save();
                userControlInvoice.SetInvoice(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
