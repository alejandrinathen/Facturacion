using BusinessObject.Interfaces;
using BusinessObject.Models;
using BusinessObject.Repository;
using BusinessObject.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facturacion.Forms
{
    public partial class FormCliente : Form, ICustomer
    {
        private MyContext _context;
        private IPresenter _presenter;
        List<CustomerType> CustomerType = new List<CustomerType>()
        {
          new BusinessObject.Models.CustomerType() {  Id = 1, Description = "Minonista"},
          new BusinessObject.Models.CustomerType() {  Id = 2, Description = "Mayorista"}
};
        public FormCliente()
        {
            InitializeComponent();
            _context = new MyContext("Test_Invoice");
            _presenter = new CustomerPresenter(_context, this);
            fillComboBox();
        }

        private void fillComboBox()
        {
            try
            {
                comboBoxCustomerTypeId.DataSource = CustomerType;
                comboBoxCustomerTypeId.DisplayMember = "Description";
                comboBoxCustomerTypeId.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion "+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Properties
        private int _Codigo;
        public int Id {
            get
            {
                int.TryParse(textBoxCodigo.Text, out _Codigo);
                if (_Codigo == 0)
                    textBoxCodigo.Text = "0";
                return _Codigo;
            }

            set
            {
                textBoxCodigo.Text = value.ToString();
            }
        }
        public string CustName
        {
            get
            {
                return textBoxCustName.Text;
            }

            set
            {
                textBoxCustName.Text = value;
            }
        }
        public string Adress 
        {
            get
            {
                return textBoxDireccion.Text;
            }

            set
            {
                textBoxDireccion.Text = value;

            }
        }
        public bool Status {
            get
            {
                return checkBoxStatus.Checked;
            }
            set => checkBoxStatus.Checked = value; 
        }
        public int CustomerTypeId 
        {
            get
            {
                return Convert.ToInt32(comboBoxCustomerTypeId.SelectedValue);
            }

            set
            {
                comboBoxCustomerTypeId.SelectedValue = value;
            }
        }
        #endregion

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FormSearchCustomer formSearchCustomer = new FormSearchCustomer(_context, "Search Customer");

                formSearchCustomer.FormClosed += (senderX, eX) =>
                {
                    if (formSearchCustomer.Id > 0)
                    {
                        _presenter.Find(formSearchCustomer.Id);
                    }
                };

                formSearchCustomer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CustName))
                {
                    errorProviderCliente.SetError(this.textBoxCustName, "No se puede dejar vacio");
                    return;
                }
                else if (string.IsNullOrEmpty(Adress))
                {
                    errorProviderCliente.SetError(this.textBoxDireccion, "No se puede dejar en blanco");
                    return;
                }
                else if (CustomerTypeId < 0)
                {
                    errorProviderCliente.SetError(this.comboBoxCustomerTypeId, "No se puede dejar vacio");
                    return;
                }
                _presenter.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
