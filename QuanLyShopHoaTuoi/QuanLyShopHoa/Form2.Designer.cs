namespace QuanLyShopHoa
{
    partial class Form2
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
            this.comboComboBox = new System.Windows.Forms.ComboBox();
            this.tbMonChinh = new System.Windows.Forms.TextBox();
            this.tbMonPhu = new System.Windows.Forms.TextBox();
            this.tbNuoc = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboComboBox
            // 
            this.comboComboBox.FormattingEnabled = true;
            this.comboComboBox.Items.AddRange(new object[] {
            "Combo 1",
            "Combo 2",
            "Combo 3",
            "Combo 4",
            "Combo 5",
            "Combo 6"});
            this.comboComboBox.Location = new System.Drawing.Point(113, 58);
            this.comboComboBox.Name = "comboComboBox";
            this.comboComboBox.Size = new System.Drawing.Size(222, 21);
            this.comboComboBox.TabIndex = 0;
            this.comboComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbMonChinh
            // 
            this.tbMonChinh.Location = new System.Drawing.Point(165, 113);
            this.tbMonChinh.Name = "tbMonChinh";
            this.tbMonChinh.Size = new System.Drawing.Size(159, 20);
            this.tbMonChinh.TabIndex = 1;
            // 
            // tbMonPhu
            // 
            this.tbMonPhu.Location = new System.Drawing.Point(165, 161);
            this.tbMonPhu.Name = "tbMonPhu";
            this.tbMonPhu.Size = new System.Drawing.Size(159, 20);
            this.tbMonPhu.TabIndex = 2;
            // 
            // tbNuoc
            // 
            this.tbNuoc.Location = new System.Drawing.Point(165, 209);
            this.tbNuoc.Name = "tbNuoc";
            this.tbNuoc.Size = new System.Drawing.Size(159, 20);
            this.tbNuoc.TabIndex = 3;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(165, 258);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(100, 20);
            this.tbGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Món chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Món phụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Combo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbNuoc);
            this.Controls.Add(this.tbMonPhu);
            this.Controls.Add(this.tbMonChinh);
            this.Controls.Add(this.comboComboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboComboBox;
        private System.Windows.Forms.TextBox tbMonChinh;
        private System.Windows.Forms.TextBox tbMonPhu;
        private System.Windows.Forms.TextBox tbNuoc;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}