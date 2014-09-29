using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankAccount : Form
    {

        account anAccount =new account();
        public BankAccount()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.name = textBoxName.Text;
            anAccount.number = textBoxNumber.Text;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            anAccount.balance = anAccount.Deposite(amount);



        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            anAccount.balance = anAccount.Withdraw(amount);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string msg =(anAccount.name + " " + anAccount.number + " " + anAccount.balance);
            MessageBox.Show(msg);

        }
    }
}
