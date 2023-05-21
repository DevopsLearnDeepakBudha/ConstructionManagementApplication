
namespace ConstructionManagementApplication.Report
{
    partial class FrmCustomerReport
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
            this.DgvContent = new System.Windows.Forms.DataGridView();
            this.Customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutStanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvContent
            // 
            this.DgvContent.AllowUserToAddRows = false;
            this.DgvContent.AllowUserToDeleteRows = false;
            this.DgvContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customerid,
            this.CustomerName,
            this.TotalAmount,
            this.CollectionAmount,
            this.OutStanding});
            this.DgvContent.Location = new System.Drawing.Point(30, 75);
            this.DgvContent.Margin = new System.Windows.Forms.Padding(4);
            this.DgvContent.Name = "DgvContent";
            this.DgvContent.ReadOnly = true;
            this.DgvContent.RowHeadersVisible = false;
            this.DgvContent.RowHeadersWidth = 51;
            this.DgvContent.RowTemplate.Height = 24;
            this.DgvContent.Size = new System.Drawing.Size(1216, 527);
            this.DgvContent.TabIndex = 4;
            this.DgvContent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContent_CellDoubleClick);
            // 
            // Customerid
            // 
            this.Customerid.HeaderText = "Customerid";
            this.Customerid.MinimumWidth = 6;
            this.Customerid.Name = "Customerid";
            this.Customerid.ReadOnly = true;
            this.Customerid.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 125;
            // 
            // CollectionAmount
            // 
            this.CollectionAmount.HeaderText = "Collection Amount";
            this.CollectionAmount.MinimumWidth = 6;
            this.CollectionAmount.Name = "CollectionAmount";
            this.CollectionAmount.ReadOnly = true;
            this.CollectionAmount.Width = 125;
            // 
            // OutStanding
            // 
            this.OutStanding.HeaderText = "OutStanding Amount";
            this.OutStanding.MinimumWidth = 6;
            this.OutStanding.Name = "OutStanding";
            this.OutStanding.ReadOnly = true;
            this.OutStanding.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSearchKeyword);
            this.groupBox1.Controls.Add(this.BtnLoad);
            this.groupBox1.Controls.Add(this.DgvContent);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 627);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Search keyword :";
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyword.Location = new System.Drawing.Point(241, 32);
            this.txtSearchKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(327, 34);
            this.txtSearchKeyword.TabIndex = 8;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.TxtSearchKeyword_TextChanged);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(1143, 32);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(103, 34);
            this.BtnLoad.TabIndex = 7;
            this.BtnLoad.Text = "Refresh";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 659);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustomerReport";
            this.Text = "FrmCustomerReport";
            this.Load += new System.EventHandler(this.FrmCustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutStanding;
        private System.Windows.Forms.Button BtnLoad;
    }
}