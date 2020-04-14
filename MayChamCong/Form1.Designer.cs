namespace MayChamCong
{
    partial class Form1
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
            this.cbDateOfMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txbIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKeMonth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDateOfMonth
            // 
            this.cbDateOfMonth.FormattingEnabled = true;
            this.cbDateOfMonth.Location = new System.Drawing.Point(74, 13);
            this.cbDateOfMonth.Name = "cbDateOfMonth";
            this.cbDateOfMonth.Size = new System.Drawing.Size(121, 21);
            this.cbDateOfMonth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày tháng";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(0, 66);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(91, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Thống kê ngày";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // txbIpAddress
            // 
            this.txbIpAddress.Location = new System.Drawing.Point(74, 40);
            this.txbIpAddress.Name = "txbIpAddress";
            this.txbIpAddress.Size = new System.Drawing.Size(120, 20);
            this.txbIpAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKeMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDateOfMonth);
            this.groupBox1.Controls.Add(this.txbIpAddress);
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lấy dữ liệu chấm công";
            // 
            // btnThongKeMonth
            // 
            this.btnThongKeMonth.Location = new System.Drawing.Point(102, 66);
            this.btnThongKeMonth.Name = "btnThongKeMonth";
            this.btnThongKeMonth.Size = new System.Drawing.Size(98, 23);
            this.btnThongKeMonth.TabIndex = 10;
            this.btnThongKeMonth.Text = "Thống kê tháng";
            this.btnThongKeMonth.UseVisualStyleBackColor = true;
            this.btnThongKeMonth.Click += new System.EventHandler(this.BtnThongKeMonth_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameStaff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnRegistration);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUID);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký thẻ";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Location = new System.Drawing.Point(74, 39);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(120, 20);
            this.txtNameStaff.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(63, 65);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 23);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "Đăng ký";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thẻ";
            // 
            // txtUID
            // 
            this.txtUID.Enabled = false;
            this.txtUID.Location = new System.Drawing.Point(74, 13);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(120, 20);
            this.txtUID.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 109);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDateOfMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txbIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThongKeMonth;
    }
}

