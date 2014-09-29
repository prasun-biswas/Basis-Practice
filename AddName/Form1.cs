using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Collections;

namespace AddName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addButton.Enabled = false;
        }

    List<string> name=new List<string>();
        private int Count = 0;
        private int Countlimit = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          Countlimit = Convert.ToInt32(EmployeetextBox.Text);
          addButton.Enabled = true;
            button1.Enabled = false;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
       // name[Count] = addNameTextBox.Text;
            name.Add(addNameTextBox.Text);
            label1.Text = (++Count).ToString();
        
            if (Count == Countlimit)
            {
               
                addButton.Enabled = false;
            }
            
           
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Count; i++)
            {
                listBox1.Items.Add(name[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            addButton.Enabled = true;
            label1.Text = "";
            addNameTextBox.Text = "";
            Count = 1;
            EmployeetextBox.Text = "";
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

    }
}








