using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDemo1
{
    public partial class Form1 : Form
    {
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;
            int years = (int)(ageDays.TotalDays / 365);
            int day = dateTimePicker1.Value.Day;
            string month = dateTimePicker1.Value.ToString("MMMM");


            LabelMessage.Text = "Hello {0} " + name + ", you will be "+(1+years)+ " year old on "+day+" "+month+".";
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
