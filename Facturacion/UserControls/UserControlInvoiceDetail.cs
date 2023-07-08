using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessObject.Models;
using BusinessObject.Interfaces;
using BusinessObject.Repository;
using BusinessObject.Services;
using System.Data;

namespace Facturacion.UserControls
{
    public delegate void CambiarSubtotalInvoice();
    public partial class UserControlInvoiceDetail : UserControl, IInvoiceDetail, IDataSource
    {
        public event CambiarSubtotalInvoice OnCambiarSubTotalInvoice = null;
        private MyContext _context;
        private InvoiceDetailPresenter _presenter;
        private int _idInvoice = 0;
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
        public int InvoiceId {
            get {
                return _idInvoice;
            }
            set { }
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
        public int Qty {
            get
            {
                return Convert.ToInt32(numericUpDownQty.Value);
            }

            set
            {
                numericUpDownQty.Value = value;
            }
        }
        public decimal Price
        {
            get
            {
                return Convert.ToInt32(numericUpDownPrice.Value);
            }

            set
            {
                numericUpDownPrice.Value = value;
            }
        }
        public decimal TotalItbis
        {
            get
            {
                return Convert.ToInt32(numericUpDownTotalItbis.Value);
            }

            set
            {
                numericUpDownTotalItbis.Value = value;
            }
        }
        public decimal SubTotal
        {
            get
            {
                return Convert.ToInt32(numericUpDownSubTotal.Value);
            }

            set
            {
                numericUpDownSubTotal.Value = value;
            }
        }
        public decimal Total
        {
            get
            {
                return Convert.ToInt32(numericUpDownTotal.Value);
            }

            set
            {
                numericUpDownTotal.Value = value;
            }
        }

        long IDataSource.Id 
        {
            get;
            set;
        }
        public object DataSource {
            get
            {
                return this.dataGridViewDetail.DataSource;
            }

            set
            {
                this.dataGridViewDetail.DataSource = value;
            }
        }
        public string TextToSearch {
            get;
            set;
        }
       
        #endregion
        public UserControlInvoiceDetail( )
        {
            InitializeComponent();
            _context = new MyContext("Test_Invoice");
            _presenter = new InvoiceDetailPresenter(_context, this);
            fillComboBox();
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
        public void SetInvoice(int idInvoice)
        {
            this._idInvoice = idInvoice;
        }
        private void calcular()
        {
            try
            {
                SubTotal = (Qty * Price);
                TotalItbis = 0.18M * SubTotal; 
                Total = TotalItbis + SubTotal;
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
                _presenter.Save();
                dataGridViewDetail.DataSource =  _presenter.FillDataSourceInvoiceDetails();
                OnCambiarSubTotalInvoice?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message+" "+ex.InnerException , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message + " " + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción " + ex.Message + " " + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDetail_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewDetail.SelectedRows.Count > 0)
                {
                    Id = Convert.ToInt32(this.dataGridViewDetail.SelectedRows[0].Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion" + ex.Message+" "+ex.Message, "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridViewDetail.DataSource = _presenter.FillDataSourceInvoiceDetails();
                OnCambiarSubTotalInvoice?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
