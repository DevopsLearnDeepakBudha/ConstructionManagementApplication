
namespace ConstructionManagementApplication.Vouchers
{
    partial class FrmReceiptsVoucher
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbClientname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtReceiptAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.LblNepaliDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AccessibleDescription = "";
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSubmit.Location = new System.Drawing.Point(467, 201);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(174, 51);
            this.BtnSubmit.TabIndex = 26;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LblNepaliDate);
            this.groupBox1.Controls.Add(this.CmbClientname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtReceiptAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSubmit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpReceiptDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(701, 301);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Entry";
            // 
            // CmbClientname
            // 
            this.CmbClientname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientname.FormattingEnabled = true;
            this.CmbClientname.Location = new System.Drawing.Point(64, 76);
            this.CmbClientname.Name = "CmbClientname";
            this.CmbClientname.Size = new System.Drawing.Size(577, 37);
            this.CmbClientname.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(64, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Client Name:";
            // 
            // TxtReceiptAmount
            // 
            this.TxtReceiptAmount.BackColor = System.Drawing.SystemColors.Window;
            this.TxtReceiptAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReceiptAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtReceiptAmount.Location = new System.Drawing.Point(64, 218);
            this.TxtReceiptAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TxtReceiptAmount.Name = "TxtReceiptAmount";
            this.TxtReceiptAmount.Size = new System.Drawing.Size(285, 34);
            this.TxtReceiptAmount.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(64, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Receipt Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(64, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Receipt On :";
            // 
            // DtpReceiptDate
            // 
            this.DtpReceiptDate.CustomFormat = "dd-MMM-yyyy";
            this.DtpReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReceiptDate.Location = new System.Drawing.Point(64, 143);
            this.DtpReceiptDate.Name = "DtpReceiptDate";
            this.DtpReceiptDate.Size = new System.Drawing.Size(211, 30);
            this.DtpReceiptDate.TabIndex = 19;
            this.DtpReceiptDate.ValueChanged += new System.EventHandler(this.DtpReceiptDate_ValueChanged);
            // 
            // LblNepaliDate
            // 
            this.LblNepaliDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNepaliDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNepaliDate.Location = new System.Drawing.Point(285, 143);
            this.LblNepaliDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNepaliDate.Name = "LblNepaliDate";
            this.LblNepaliDate.Size = new System.Drawing.Size(236, 29);
            this.LblNepaliDate.TabIndex = 33;
            this.LblNepaliDate.Text = "Nepalese Date";
            // 
            // FrmReceiptsVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReceiptsVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReceiptsVoucher";
            this.Load += new System.EventHandler(this.FrmReceiptsVoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpReceiptDate;
        private System.Windows.Forms.TextBox TxtReceiptAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbClientname;
        private System.Windows.Forms.Label LblNepaliDate;
    }
}