
namespace ConstructionManagementApplication.Vouchers
{
    partial class FrmSalesVoucher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkSalesReturn = new System.Windows.Forms.CheckBox();
            this.CmbClientname = new System.Windows.Forms.ComboBox();
            this.CmbItemname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.TxtReceipt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblNoOfItems = new System.Windows.Forms.Label();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.SalesDetailid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtitemrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInvoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChkSalesReturn);
            this.groupBox1.Controls.Add(this.CmbClientname);
            this.groupBox1.Controls.Add(this.CmbItemname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpInvoiceDate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DgvProduct);
            this.groupBox1.Controls.Add(this.txtTotalprice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtitemrate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtInvoice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 742);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Entry";
            // 
            // ChkSalesReturn
            // 
            this.ChkSalesReturn.AutoSize = true;
            this.ChkSalesReturn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkSalesReturn.Location = new System.Drawing.Point(442, 111);
            this.ChkSalesReturn.Name = "ChkSalesReturn";
            this.ChkSalesReturn.Size = new System.Drawing.Size(173, 33);
            this.ChkSalesReturn.TabIndex = 20;
            this.ChkSalesReturn.Text = "Sales Return";
            this.ChkSalesReturn.UseVisualStyleBackColor = true;
            // 
            // CmbClientname
            // 
            this.CmbClientname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientname.FormattingEnabled = true;
            this.CmbClientname.Location = new System.Drawing.Point(38, 109);
            this.CmbClientname.Name = "CmbClientname";
            this.CmbClientname.Size = new System.Drawing.Size(387, 37);
            this.CmbClientname.TabIndex = 22;
            this.CmbClientname.SelectedIndexChanged += new System.EventHandler(this.CmbClientname_SelectedIndexChanged);
            // 
            // CmbItemname
            // 
            this.CmbItemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbItemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbItemname.FormattingEnabled = true;
            this.CmbItemname.Location = new System.Drawing.Point(38, 225);
            this.CmbItemname.Name = "CmbItemname";
            this.CmbItemname.Size = new System.Drawing.Size(245, 37);
            this.CmbItemname.TabIndex = 21;
            this.CmbItemname.SelectedIndexChanged += new System.EventHandler(this.CmbItemname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(309, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date Of Sales On :";
            // 
            // DtpInvoiceDate
            // 
            this.DtpInvoiceDate.CustomFormat = "dd-MMM-yyyy";
            this.DtpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpInvoiceDate.Location = new System.Drawing.Point(309, 50);
            this.DtpInvoiceDate.Name = "DtpInvoiceDate";
            this.DtpInvoiceDate.Size = new System.Drawing.Size(235, 30);
            this.DtpInvoiceDate.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRemove);
            this.groupBox2.Controls.Add(this.TxtReceipt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.LblTotalAmount);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Controls.Add(this.LblNoOfItems);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(660, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Summary";
            // 
            // BtnRemove
            // 
            this.BtnRemove.AccessibleDescription = "";
            this.BtnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRemove.Location = new System.Drawing.Point(44, 224);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(154, 45);
            this.BtnRemove.TabIndex = 20;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // TxtReceipt
            // 
            this.TxtReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReceipt.Location = new System.Drawing.Point(180, 101);
            this.TxtReceipt.Name = "TxtReceipt";
            this.TxtReceipt.Size = new System.Drawing.Size(212, 34);
            this.TxtReceipt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(61, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Receipt :";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = "";
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(238, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 45);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTotalAmount.Location = new System.Drawing.Point(2, 65);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(167, 29);
            this.LblTotalAmount.TabIndex = 6;
            this.LblTotalAmount.Text = "Total Amount :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleDescription = "";
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(238, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 45);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleDescription = "";
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdd.Location = new System.Drawing.Point(44, 162);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(154, 45);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblNoOfItems
            // 
            this.LblNoOfItems.AutoSize = true;
            this.LblNoOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoOfItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNoOfItems.Location = new System.Drawing.Point(17, 35);
            this.LblNoOfItems.Name = "LblNoOfItems";
            this.LblNoOfItems.Size = new System.Drawing.Size(152, 29);
            this.LblNoOfItems.TabIndex = 4;
            this.LblNoOfItems.Text = "No Of Items :";
            // 
            // DgvProduct
            // 
            this.DgvProduct.AllowUserToAddRows = false;
            this.DgvProduct.AllowUserToDeleteRows = false;
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesDetailid,
            this.Productid,
            this.Productname,
            this.Rate,
            this.Qnty,
            this.TotalPrice});
            this.DgvProduct.Location = new System.Drawing.Point(38, 335);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            this.DgvProduct.RowHeadersVisible = false;
            this.DgvProduct.RowHeadersWidth = 51;
            this.DgvProduct.RowTemplate.Height = 24;
            this.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProduct.Size = new System.Drawing.Size(1033, 400);
            this.DgvProduct.TabIndex = 1;
            this.DgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellDoubleClick);
            // 
            // SalesDetailid
            // 
            this.SalesDetailid.HeaderText = "SalesDetailid";
            this.SalesDetailid.MinimumWidth = 6;
            this.SalesDetailid.Name = "SalesDetailid";
            this.SalesDetailid.ReadOnly = true;
            this.SalesDetailid.Visible = false;
            this.SalesDetailid.Width = 125;
            // 
            // Productid
            // 
            this.Productid.HeaderText = "Productid";
            this.Productid.MinimumWidth = 6;
            this.Productid.Name = "Productid";
            this.Productid.ReadOnly = true;
            this.Productid.Width = 150;
            // 
            // Productname
            // 
            this.Productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productname.HeaderText = "Product Name";
            this.Productname.MinimumWidth = 6;
            this.Productname.Name = "Productname";
            this.Productname.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 125;
            // 
            // Qnty
            // 
            this.Qnty.HeaderText = "Qnty";
            this.Qnty.MinimumWidth = 6;
            this.Qnty.Name = "Qnty";
            this.Qnty.ReadOnly = true;
            this.Qnty.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalprice.Enabled = false;
            this.txtTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalprice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalprice.Location = new System.Drawing.Point(309, 287);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(235, 34);
            this.txtTotalprice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(309, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Price :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantity.Location = new System.Drawing.Point(38, 287);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(245, 34);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.Leave += new System.EventHandler(this.TxtQuantity_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(38, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity :";
            // 
            // txtitemrate
            // 
            this.txtitemrate.BackColor = System.Drawing.SystemColors.Window;
            this.txtitemrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemrate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtitemrate.Location = new System.Drawing.Point(309, 225);
            this.txtitemrate.Name = "txtitemrate";
            this.txtitemrate.Size = new System.Drawing.Size(235, 34);
            this.txtitemrate.TabIndex = 11;
            this.txtitemrate.Leave += new System.EventHandler(this.Txtitemrate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(309, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Per Item Rate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(38, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(38, 150);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(577, 47);
            this.txtAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name:";
            // 
            // TxtInvoice
            // 
            this.TxtInvoice.BackColor = System.Drawing.SystemColors.Window;
            this.TxtInvoice.Enabled = false;
            this.TxtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtInvoice.Location = new System.Drawing.Point(38, 50);
            this.TxtInvoice.Name = "TxtInvoice";
            this.TxtInvoice.Size = new System.Drawing.Size(245, 34);
            this.TxtInvoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice #:";
            // 
            // FrmSalesVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1141, 770);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSalesVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalesVoucher";
            this.Load += new System.EventHandler(this.FrmSalesVoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInvoice;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtitemrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblNoOfItems;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.TextBox TxtReceipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpInvoiceDate;
        private System.Windows.Forms.CheckBox ChkSalesReturn;
        private System.Windows.Forms.ComboBox CmbClientname;
        private System.Windows.Forms.ComboBox CmbItemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDetailid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button BtnRemove;
    }
}