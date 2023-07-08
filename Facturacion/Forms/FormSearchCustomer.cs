using BusinessObject.Interfaces;
using BusinessObject.Repository;
using BusinessObject.Services;
using System;
using System.Windows.Forms;

namespace Facturacion.Forms
{
    public partial class FormSearchCustomer : Form, IDataSource
    {
        ISearchCustomerPresenter _presenter;
        private FormSearchCustomer()
        {

        }
        public FormSearchCustomer(MyContext context, string Title)
        {
            InitializeComponent();
            _presenter = new SearchCustomerPresenter(context, this);
            this.Text = Title;
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormBusqueda
        //    // 
        //    this.ClientSize = new System.Drawing.Size(839, 261);
        //    this.Name = "FormBusqueda";
        //    this.ResumeLayout(false);

        //}

        #region Properties
        public long Id 
        {
            get;
            set;
        }
        public object DataSource
        {
            get
            {
                return this.dataGridViewCustomer.DataSource;
            }

            set
            {
                this.dataGridViewCustomer.DataSource = value;
            }
        }
        public string TextToSearch
        {
            get
            {
                return this.textBoxBuscar.Text;
            }

            set
            {
                this.textBoxBuscar.Text = value;
            }
        }
        #endregion

        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            try
            {
                _presenter.Find();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion", "Aviso" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCustomer_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion", "Aviso" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCustomer.SelectedRows.Count > 0)
                {
                    Id = Convert.ToInt64(this.dataGridViewCustomer.SelectedRows[0].Cells[0].Value);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepcion", "Aviso" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
