using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "題目：計算該年有幾個星期六、星期日";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int year = int.Parse(input) + 1911;
            DateTime datestar = new DateTime(year, 01, 01);//設定開始日期
            DateTime dateend = new DateTime(year, 12, 31);//結束日期
            int satday = 0;
            int sunday = 0;

            while (datestar < dateend)
            {
                if ((int)datestar.DayOfWeek == 0)
                {
                    satday += 1;
                }

                if ((int)datestar.DayOfWeek == 6)
                {
                    sunday += 1;
                }
                datestar = datestar.AddDays(1);
            }

            label2.Text = ("星期六：" + satday + "天，星期日：" + sunday + "天");
        }
    }
}
