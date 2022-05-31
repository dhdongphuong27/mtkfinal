using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopHoa
{
    public partial class Form1 : Form
    {
        String description;
        String price;
        public Form1()
        {
            InitializeComponent();
            drinkComboBox.SelectedIndex = 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] toppings = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < checkedListBox.CheckedIndices.Count; i++)
            {
                toppings[checkedListBox.CheckedIndices[i]] = 1;
            }
            int index = drinkComboBox.SelectedIndex;
            ThucUong thucUong = new TraDa();
            switch (index)
            {
                case 0:
                    thucUong = new TraSua();
                    break;
                case 1:
                    thucUong = new SuaTuoi();
                    break;
                case 2:
                    thucUong = new CaPhe();
                    break;
                case 3:
                    thucUong = new TraDao();
                    break;
                case 4:
                    thucUong = new TraTao();
                    break;
                case 5:
                    thucUong = new NuocEpTraiCay();
                    break;
                case 6:
                    thucUong = new NuocChanh();
                    break;
                case 7:
                    thucUong = new TraDa();
                    break;
            }

            if (toppings[0] == 1)
                thucUong = new PuddingTrungDecorator(thucUong);
            if (toppings[1] == 1)
                thucUong = new ThachPhoMaiDecorator(thucUong);
            if (toppings[2] == 1)
                thucUong = new TranChauTrangDecorator(thucUong);
            if (toppings[3] == 1)
                thucUong = new ThachTraXanhDecorator(thucUong);
            if (toppings[4] == 1)
                thucUong = new BanhFlanDecorator(thucUong);
            if (toppings[5] == 1)
                thucUong = new ThachTraiCayDecorator(thucUong);
            if (toppings[6] == 1)
                thucUong = new TranChauDenDecorator(thucUong);
            if (toppings[7] == 1)
                thucUong = new PuddingKhoaiMonDecorator(thucUong);
            if (toppings[8] == 1)
                thucUong = new KemPhoMaiDecorator(thucUong);
            if (toppings[9] == 1)
                thucUong = new KemMuoiDecorator(thucUong);
            if (toppings[10] == 1)
                thucUong = new ThachNhoDecorator(thucUong);
            description = thucUong.GetDescription();
            price = thucUong.GetCost().ToString();
            detailsRichTextBox.Text = description;
            priceTextBox.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = "";
            detailsRichTextBox.Text = "";
            drinkComboBox.SelectedIndex = 7;
            foreach (int i in checkedListBox.CheckedIndices)
            {
                checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
