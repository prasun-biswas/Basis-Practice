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
        person aPerson = new person();
        private void button1_Click(object sender, EventArgs e)
        {
            aPerson.Firstname = textBoxFirstName.Text;
            aPerson.Middlename = textBoxMiddleName.Text;
            aPerson.Lastname = textBoxLastName.Text;

            textBoxFullName.Text=aPerson.GetFullname();
            textBoxReverseName.Text = aPerson.GetReverseName();
        }
    }
}
