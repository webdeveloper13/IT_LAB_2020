using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ques3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bonus = 0.0;
            double sal = 0.0;
            double.TryParse(textBox1.Text, out sal);
            if(comboBox1.SelectedItem.ToString()=="LEVEL 1")
            {
                bonus = 0.1 * sal;
            }

            else if(comboBox1.SelectedItem.ToString()=="LEVEL 2" || comboBox1.SelectedItem.ToString()=="LEVEL 3" || comboBox1.SelectedItem.ToString()=="LEVEL 4")
            {
                bonus = 0.09 * sal;
            }

            else if(comboBox1.SelectedItem.ToString()=="LEVEL 5" || comboBox1.SelectedItem.ToString()=="LEVEL 6" || comboBox1.SelectedItem.ToString()=="LEVEL 7")
            {
                bonus = 0.07 * sal;
            }

            else if(comboBox1.SelectedItem.ToString()=="LEVEL 8" || comboBox1.SelectedItem.ToString()=="LEVEL 9" || comboBox1.SelectedItem.ToString()=="LEVEL 10")
            {
                bonus = 0.05 * sal;

            }

            textBox2.Text = bonus.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            comboBox1.Text = "";

        }
    }
}
