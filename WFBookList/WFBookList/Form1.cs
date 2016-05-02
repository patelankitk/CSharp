using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBookList
{
    public partial class Form1 : Form
    {
        List<books> BookList = new List<books>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonAdd.Visible = false;
            buttonDelete.Visible = false;
            buttonList.Visible = false;
            labelMain.Visible = false;
            labelList.Visible = false;
            buttonBack.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            button1.Visible = true;

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonAdd.Visible = false;
            buttonDelete.Visible = false;
            buttonList.Visible = false;
            labelMain.Visible = false;
            labelList.Visible = true;
            buttonBack.Visible = true;

            listView1.Visible = true;

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            //foreach (books b in BookList)
            //{
            //    textBox5.Text = b.title;
            //    textBox6.Text = b.author;
            //    textBox7.Text = b.ISBN.ToString();
            //    textBox8.Text = b.price.ToString();
            //}


            textBox6.Text = listView1.CheckedItems[0].Index.ToString();
            //textBox7.Text = (BookList[listView1.SelectedItems[0].Index].ISBN).ToString();
            //textBox8.Text = (BookList[listView1.SelectedItems[0].Index].price).ToString();









        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            buttonAdd.Visible = true;
            buttonDelete.Visible = true;
            buttonList.Visible = true;
            labelMain.Visible = true;
            labelList.Visible = false;
            buttonBack.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            button1.Visible = false;

            listView1.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // for (int i = 0; i < 1; i++)
            //{
            books b1 = new books();
            b1.title = textBox1.Text;
            b1.author = textBox2.Text;
            b1.ISBN = int.Parse(textBox3.Text);
            b1.price = double.Parse(textBox4.Text);
            BookList.Add(b1);
            listView1.Items.Add(b1.title);

            //}



            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
