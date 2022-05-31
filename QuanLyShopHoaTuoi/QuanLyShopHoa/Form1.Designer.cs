namespace QuanLyShopHoa
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
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.detailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Items.AddRange(new object[] {
            "Trà sữa - 20000",
            "Sữa tươi - 10000",
            "Cà phê - 12000",
            "Trà đào - 15000",
            "Trà táo - 17000",
            "Nước ép trái cây - 16000",
            "Nước chanh - 9500",
            "Trà đá - 5000"});
            this.drinkComboBox.Location = new System.Drawing.Point(298, 64);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(234, 24);
            this.drinkComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thức uống";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Pudding trứng - 2000",
            "Thạch phô mai - 2000",
            "Trân châu trắng - 1500",
            "Thạch trà xanh - 1200",
            "Bánh flan - 1100",
            "Thạch trái cây - 800",
            "Trân châu đen - 500",
            "Pudding khoai môn - 2100",
            "Kem phô mai - 3000",
            "Kem muối - 1700",
            "Thạch nho - 2200"});
            this.checkedListBox.Location = new System.Drawing.Point(81, 143);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(412, 191);
            this.checkedListBox.TabIndex = 2;
            // 
            // detailsRichTextBox
            // 
            this.detailsRichTextBox.Location = new System.Drawing.Point(564, 143);
            this.detailsRichTextBox.Name = "detailsRichTextBox";
            this.detailsRichTextBox.Size = new System.Drawing.Size(172, 149);
            this.detailsRichTextBox.TabIndex = 3;
            this.detailsRichTextBox.Text = "";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(564, 312);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(172, 22);
            this.priceTextBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đặt món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.detailsRichTextBox);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinkComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drinkComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.RichTextBox detailsRichTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}