using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboComboBox.SelectedIndex;
            LauchCombo lc = new Combo1();//tạm
            switch (index)
            {
                case 0:
                    lc = new Combo1();
                    break;
                case 1:
                    lc = new Combo2();
                    break;
                case 2:
                    lc = new Combo3();
                    break;
                case 3:
                    lc = new Combo4();
                    break;
                case 4:
                    lc = new Combo5();
                    break;
            }
            Combo cb = lc.ComboOrder();
            tbMonChinh.Text = cb.getMonChinh().GetTenMon();
            tbMonPhu.Text = cb.GetMonPhu().GetTenMon();
            tbNuoc.Text = cb.GetNuocGiaiKhat().GetTenMon();
            tbGia.Text = cb.getGia().ToString();
        }
    }
}
