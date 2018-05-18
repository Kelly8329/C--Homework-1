using HomeWork04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork04
{
    public partial class Form1 : Form
    {
        private List<TicketFare> Data { get; set; }

        public Form1()
        {
            InitializeComponent();
            Data = PriceList.GetTicketList();
            toSouthRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            startComboBox.SelectedIndexChanged += StartComboBox_SelectedIndexChanged;
            toSouthRadioButton.Checked = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toSouthRadioButton.Checked)
            {
                SetToSouthStartCombobox();
            }
            else
            {
                SetToNorthStartCombobox();
            }
        }

        private void StartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (toSouthRadioButton.Checked)
            {
                SetToSouthEndCombobox();
            }
            else
            {
                SetToNorthEndCombobox();
            }

        }

        private void SetToSouthStartCombobox()
        {
            startComboBox.DataSource = Data.GroupBy((x) => x.StartStation).Select((x) => x.Key).ToList();
        }

        private void SetToNorthStartCombobox()
        {
            startComboBox.DataSource = Data.GroupBy((x) => x.EndStation).Select((x) => x.Key).ToList();
        }

        private void SetToSouthEndCombobox()
        {
            string start = GetStartStation();
            endComboBox.DataSource = Data.Where((x) => x.StartStation == start).Select((x) => x.EndStation).ToList();

        }

        private string GetStartStation()
        {
            return startComboBox.SelectedItem.ToString();
        }

        private void SetToNorthEndCombobox()
        {
            string start = GetStartStation();
            endComboBox.DataSource = Data.Where((x) => x.EndStation == start).Select((x) => x.StartStation).ToList();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var calculator = new TicketCalculator();
            string start = startComboBox.SelectedItem.ToString();
            string end = endComboBox.SelectedItem.ToString();
            bool isToSouth = false;
            if (toSouthRadioButton.Checked)
            {
                isToSouth = true;
            }
            var result = calculator.GetFare(start, end, checkBox1.Checked, checkBox2.Checked, isToSouth);
            if (result.HasValue)
            {
                label4.Text = result.Fare.ToString();
            }
            else
            {
                label4.Text = "查無此起訖站";
            }
        }
    }
}

