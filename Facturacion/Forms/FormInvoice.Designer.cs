namespace Facturacion.Forms
{
    partial class FormInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelTotalItbis = new System.Windows.Forms.Label();
            this.numericUpDownTotalItbis = new System.Windows.Forms.NumericUpDown();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.numericUpDownSubTotal = new System.Windows.Forms.NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalItbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(73, 34);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomer.TabIndex = 1;
            // 
            // labelTotalItbis
            // 
            this.labelTotalItbis.AutoSize = true;
            this.labelTotalItbis.Location = new System.Drawing.Point(6, 65);
            this.labelTotalItbis.Name = "labelTotalItbis";
            this.labelTotalItbis.Size = new System.Drawing.Size(53, 13);
            this.labelTotalItbis.TabIndex = 2;
            this.labelTotalItbis.Text = "Total Itbis";
            // 
            // numericUpDownTotalItbis
            // 
            this.numericUpDownTotalItbis.Enabled = false;
            this.numericUpDownTotalItbis.Location = new System.Drawing.Point(73, 59);
            this.numericUpDownTotalItbis.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownTotalItbis.Name = "numericUpDownTotalItbis";
            this.numericUpDownTotalItbis.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotalItbis.TabIndex = 3;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(218, 15);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(53, 13);
            this.labelSubTotal.TabIndex = 4;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // numericUpDownSubTotal
            // 
            this.numericUpDownSubTotal.Enabled = false;
            this.numericUpDownSubTotal.Location = new System.Drawing.Point(277, 12);
            this.numericUpDownSubTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownSubTotal.Name = "numericUpDownSubTotal";
            this.numericUpDownSubTotal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSubTotal.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(218, 41);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // numericUpDownTotal
            // 
            this.numericUpDownTotal.Enabled = false;
            this.numericUpDownTotal.Location = new System.Drawing.Point(276, 38);
            this.numericUpDownTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownTotal.Name = "numericUpDownTotal";
            this.numericUpDownTotal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotal.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(73, 11);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(80, 20);
            this.textBoxId.TabIndex = 8;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 113);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(817, 532);
            this.panel.TabIndex = 9;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonNuevo);
            this.groupBoxButtons.Controls.Add(this.buttonSalvar);
            this.groupBoxButtons.Location = new System.Drawing.Point(423, 12);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(266, 48);
            this.groupBoxButtons.TabIndex = 42;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(19, 17);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(74, 20);
            this.buttonNuevo.TabIndex = 23;
            this.buttonNuevo.Text = "New";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(99, 17);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(71, 20);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "Save";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(6, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 43;
            this.labelId.Text = "Id";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(12, 95);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(45, 13);
            this.labelDetalle.TabIndex = 44;
            this.labelDetalle.Text = "DETAIL";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBoxButtons);
            this.groupBox1.Controls.Add(this.comboBoxCustomer);
            this.groupBox1.Controls.Add(this.labelTotalItbis);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.numericUpDownTotalItbis);
            this.groupBox1.Controls.Add(this.numericUpDownTotal);
            this.groupBox1.Controls.Add(this.labelSubTotal);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.numericUpDownSubTotal);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVOICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.panel);
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalItbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelTotalItbis;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalItbis;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownSubTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownTotal;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}