namespace Facturacion.UserControls
{
    partial class UserControlInvoiceDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.labelQty = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDownSubTotal = new System.Windows.Forms.NumericUpDown();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.numericUpDownTotalItbis = new System.Windows.Forms.NumericUpDown();
            this.labelTotalItbis = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalItbis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonNuevo);
            this.groupBoxButtons.Controls.Add(this.buttonSalvar);
            this.groupBoxButtons.Location = new System.Drawing.Point(415, 2);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(266, 85);
            this.groupBoxButtons.TabIndex = 41;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(19, 36);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(74, 20);
            this.buttonNuevo.TabIndex = 23;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(99, 36);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(71, 20);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Location = new System.Drawing.Point(9, 132);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.ReadOnly = true;
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.Size = new System.Drawing.Size(672, 271);
            this.dataGridViewDetail.TabIndex = 40;
            this.dataGridViewDetail.DoubleClick += new System.EventHandler(this.dataGridViewDetail_DoubleClick);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(254, 82);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrice.TabIndex = 39;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(215, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 38;
            this.labelPrice.Text = "Price";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(254, 57);
            this.numericUpDownQty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(109, 20);
            this.numericUpDownQty.TabIndex = 37;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(215, 59);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(23, 13);
            this.labelQty.TabIndex = 36;
            this.labelQty.Text = "Qty";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(73, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(80, 20);
            this.textBoxId.TabIndex = 35;
            // 
            // numericUpDownTotal
            // 
            this.numericUpDownTotal.Enabled = false;
            this.numericUpDownTotal.Location = new System.Drawing.Point(73, 106);
            this.numericUpDownTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownTotal.Name = "numericUpDownTotal";
            this.numericUpDownTotal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotal.TabIndex = 34;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(6, 111);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 33;
            this.labelTotal.Text = "Total";
            // 
            // numericUpDownSubTotal
            // 
            this.numericUpDownSubTotal.Enabled = false;
            this.numericUpDownSubTotal.Location = new System.Drawing.Point(73, 82);
            this.numericUpDownSubTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownSubTotal.Name = "numericUpDownSubTotal";
            this.numericUpDownSubTotal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSubTotal.TabIndex = 32;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(6, 85);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(53, 13);
            this.labelSubTotal.TabIndex = 31;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // numericUpDownTotalItbis
            // 
            this.numericUpDownTotalItbis.Enabled = false;
            this.numericUpDownTotalItbis.Location = new System.Drawing.Point(73, 57);
            this.numericUpDownTotalItbis.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownTotalItbis.Name = "numericUpDownTotalItbis";
            this.numericUpDownTotalItbis.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotalItbis.TabIndex = 30;
            // 
            // labelTotalItbis
            // 
            this.labelTotalItbis.AutoSize = true;
            this.labelTotalItbis.Location = new System.Drawing.Point(6, 59);
            this.labelTotalItbis.Name = "labelTotalItbis";
            this.labelTotalItbis.Size = new System.Drawing.Size(53, 13);
            this.labelTotalItbis.TabIndex = 29;
            this.labelTotalItbis.Text = "Total Itbis";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(73, 33);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomer.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(6, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 42;
            this.labelId.Text = "Id";
            // 
            // UserControlInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.numericUpDownTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.numericUpDownSubTotal);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.numericUpDownTotalItbis);
            this.Controls.Add(this.labelTotalItbis);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.label1);
            this.Name = "UserControlInvoiceDetail";
            this.Size = new System.Drawing.Size(691, 417);
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalItbis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.NumericUpDown numericUpDownTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownSubTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalItbis;
        private System.Windows.Forms.Label labelTotalItbis;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
    }
}
