using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            


        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonQ1A1.Checked)
            {
                
                labelA1.Text = "\u00fc"; 
            }

            else
            {
                labelA1.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                
                labelA1.Text = "\u00fb"; 
            }

            else
            {
                labelA1.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {

                labelA1.Text = "\u00fb"; 
            }

            else
            {
                labelA1.Text = "";
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {

                labelA2.Text = "\u00fb"; 
            }

            else
            {
                labelA2.Text = "";
            }

        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {

                labelA2.Text = "\u00fc"; 
            }

            else
            {
                labelA2.Text = "";
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {

                labelA2.Text = "\u00fb"; 
            }

            else
            {
                labelA2.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {

                labelA3.Text = "\u00fb"; 
            }

            else
            {
                labelA3.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {

                labelA3.Text = "\u00fb"; 
            }

            else
            {
                labelA3.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {

                labelA3.Text = "\u00fc"; 
            }

            else
            {
                labelA3.Text = "";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
