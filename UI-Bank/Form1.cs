using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;
using System.IO;

namespace UI_Bank
{
    public partial class Form1 : Form
    {
        AccountBO abo = new AccountBO();
        List<Account> acl = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        #region Create Button
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            acl.Clear();
            abo.readBankAccount(acl);
            Account ac = new Account();
            try
            {
                int f = 0;
                ac.accountNumber = AccountNumberBox.Text;
                for (int j = 0; j < acl.Count(); j++)
                {
                    if (acl[j].accountNumber == AccountNumberBox.Text)
                    {
                        f = 1;
                    }
                }
                if(f==1)
                {
                    MessageBox.Show("This Account Number is already used.\nPlease re-check", "Error");
                }
                else
                {
                    ac.holderName1 = Holder1Box.Text;
                    ac.holderName2 = Holder2Box.Text;
                    ac.balance = Convert.ToDouble(BalanceBox.Text);
                    ac.bankName = BankNameBox.Text;
                    ac.bankBranch = BranchBox.Text;
                    acl.Add(ac);

                    abo.createBankAccount(acl);
                    MessageBox.Show("New Bank Account Created Succesfully", "Successful");
                }

                AccountNumberBox.Clear();
                Holder1Box.Clear();
                Holder2Box.Clear();
                BalanceBox.Clear();
                BankNameBox.Clear();
                BranchBox.Clear();
            }
            catch(Exception e2)
            {
                BalanceBox.Clear();
                MessageBox.Show("Please enter the balance in numeric", "Caution");
            }
            
        }
        #endregion

        #region Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Search Button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        #endregion

        #region Update Button 
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
        #endregion
    }
}
