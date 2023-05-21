
namespace ConstructionManagementApplication.Vouchers
{
    partial class FrmSalesVoucherReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.DgvCollection = new System.Windows.Forms.DataGridView();
            this.Receiptid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalCollection = new System.Windows.Forms.Label();
            this.LblOutstanding = new System.Windows.Forms.Label();
            this.Salesid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSalesReturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollection)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salesid,
            this.InvoiceDate,
            this.InvoiceNumber,
            this.Status,
            this.TotalAmount});
            this.DgvOrder.Location = new System.Drawing.Point(20, 17);
            this.DgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.RowHeadersVisible = false;
            this.DgvOrder.RowHeadersWidth = 51;
            this.DgvOrder.RowTemplate.Height = 24;
            this.DgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrder.Size = new System.Drawing.Size(1050, 604);
            this.DgvOrder.TabIndex = 3;
            this.DgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrder_CellDoubleClick);
            // 
            // BtnNew
            // 
            this.BtnNew.AccessibleDescription = "";
            this.BtnNew.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNew.Location = new System.Drawing.Point(13, 30);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(139, 51);
            this.BtnNew.TabIndex = 22;
            this.BtnNew.Text = "New Sales";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.AccessibleDescription = "";
            this.BtnReceipt.BackColor = System.Drawing.SystemColors.Control;
            this.BtnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnReceipt.Location = new System.Drawing.Point(160, 30);
            this.BtnReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(166, 51);
            this.BtnReceipt.TabIndex = 23;
            this.BtnReceipt.Text = "New Receipt";
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // DgvCollection
            // 
            this.DgvCollection.AllowUserToAddRows = false;
            this.DgvCollection.AllowUserToDeleteRows = false;
            this.DgvCollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Receiptid,
            this.CollectionDate,
            this.ReceiptAmount});
            this.DgvCollection.Location = new System.Drawing.Point(1078, 17);
            this.DgvCollection.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCollection.Name = "DgvCollection";
            this.DgvCollection.ReadOnly = true;
            this.DgvCollection.RowHeadersVisible = false;
            this.DgvCollection.RowHeadersWidth = 51;
            this.DgvCollection.RowTemplate.Height = 24;
            this.DgvCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCollection.Size = new System.Drawing.Size(482, 604);
            this.DgvCollection.TabIndex = 24;
            this.DgvCollection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCollection_CellDoubleClick);
            // 
            // Receiptid
            // 
            this.Receiptid.HeaderText = "Receiptid";
            this.Receiptid.MinimumWidth = 6;
            this.Receiptid.Name = "Receiptid";
            this.Receiptid.ReadOnly = true;
            this.Receiptid.Visible = false;
            this.Receiptid.Width = 125;
            // 
            // CollectionDate
            // 
            this.CollectionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd MMM yyyy";
            this.CollectionDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.CollectionDate.HeaderText = "Receipt Date";
            this.CollectionDate.MinimumWidth = 6;
            this.CollectionDate.Name = "CollectionDate";
            this.CollectionDate.ReadOnly = true;
            // 
            // ReceiptAmount
            // 
            this.ReceiptAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ReceiptAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReceiptAmount.HeaderText = "Receipt Amount";
            this.ReceiptAmount.MinimumWidth = 6;
            this.ReceiptAmount.Name = "ReceiptAmount";
            this.ReceiptAmount.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DgvOrder);
            this.panel1.Controls.Add(this.DgvCollection);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 644);
            this.panel1.TabIndex = 25;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalAmount.Location = new System.Drawing.Point(579, 30);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(246, 31);
            this.lblTotalAmount.TabIndex = 26;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblTotalCollection
            // 
            this.lblTotalCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCollection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCollection.Location = new System.Drawing.Point(1093, 30);
            this.lblTotalCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCollection.Name = "lblTotalCollection";
            this.lblTotalCollection.Size = new System.Drawing.Size(246, 31);
            this.lblTotalCollection.TabIndex = 27;
            this.lblTotalCollection.Text = "Total Collection :";
            // 
            // LblOutstanding
            // 
            this.LblOutstanding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutstanding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblOutstanding.Location = new System.Drawing.Point(1350, 30);
            this.LblOutstanding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOutstanding.Name = "LblOutstanding";
            this.LblOutstanding.Size = new System.Drawing.Size(246, 31);
            this.LblOutstanding.TabIndex = 28;
            this.LblOutstanding.Text = "OutStanding :";
            // 
            // Salesid
            // 
            this.Salesid.HeaderText = "Salesid";
            this.Salesid.MinimumWidth = 6;
            this.Salesid.Name = "Salesid";
            this.Salesid.ReadOnly = true;
            this.Salesid.Visible = false;
            this.Salesid.Width = 125;
            // 
            // InvoiceDate
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "dd MMM yyyy";
            this.InvoiceDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.InvoiceDate.HeaderText = "Invoice Date";
            this.InvoiceDate.MinimumWidth = 6;
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            this.InvoiceDate.Width = 120;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceNumber.HeaderText = "Invoice #";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Type";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // TotalAmount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 125;
            // 
            // LblSalesReturn
            // 
            this.LblSalesReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSalesReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSalesReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalesReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblSalesReturn.Location = new System.Drawing.Point(836, 30);
            this.LblSalesReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSalesReturn.Name = "LblSalesReturn";
            this.LblSalesReturn.Size = new System.Drawing.Size(246, 31);
            this.LblSalesReturn.TabIndex = 29;
            this.LblSalesReturn.Text = "Sales Return :";
            // 
            // FrmSalesVoucherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1625, 744);
            this.Controls.Add(this.LblSalesReturn);
            this.Controls.Add(this.LblOutstanding);
            this.Controls.Add(this.lblTotalCollection);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnReceipt);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalesVoucherReport";
            this.Text = "FrmSalesVoucher";
            this.Load += new System.EventHandler(this.FrmSalesVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Windows.Forms.DataGridView DgvCollection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalCollection;
        private System.Windows.Forms.Label LblOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiptid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Label LblSalesReturn;
    }
}