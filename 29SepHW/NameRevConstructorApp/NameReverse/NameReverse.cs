using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameReverse
{
    public partial class NameReverse : Form
    {
        public NameReverse()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            person aPerson = new person(textBoxFirstName.Text,textBoxMiddleName.Text,textBoxLastName.Text);

            //aPerson.Firstname = textBoxFirstName.Text;
            //aPerson.Middlename = textBoxMiddleName.Text;
            //aPerson.Lastname = textBoxLastName.Text;

            textBoxFullName.Text=aPerson.GetFullname();
            textBoxReverseName.Text = aPerson.GetReverseName();
        }
    }
}
