using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentForm
{
    public partial class Form1 : Form
    {
        string name = "";
        string doctorName = "";
        
        DateTime date1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }

        private void textBoxDoctor_TextChanged(object sender, EventArgs e)
        {
            doctorName = textBoxDoctor.Text;
        }

        private void dateTimePickerAD_ValueChanged(object sender, EventArgs e)
        {
            date1 = dateTimePickerAD.Value;
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            labelMessage.Text =name+" your appointment with Doctor "+doctorName+" on "+ date1.ToShortDateString()+ " has been booked.";
        }
    }
}
