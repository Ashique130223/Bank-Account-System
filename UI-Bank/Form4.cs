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

namespace UI_Bank
{
    public partial class Form4 : Form
    {
        AccountBO abo = new AccountBO();

        public Form4()
        {
            InitializeComponent();
        }

        #region Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Update Button
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List<Account> aclsit = new List<Account>();
            int i = 0;
            abo.readBankAccount(aclsit);

            for (int j = 0; j < aclsit.Count(); j++)
            {
                if (aclsit[j].accountNumber == textBoxAccNo.Text)
                {
                    i = 1;
                    aclsit[j].holderName1= Holder1Box.Text;
                    aclsit[j].holderName2 = Holder2Box.Text;
                    if (flag == 0)
                        aclsit[j].balance += Convert.ToDouble(BalanceBox.Text);
                    else if (flag == 1)
                        aclsit[j].balance -= Convert.ToDouble(BalanceBox.Text);
                    else if (flag == 2)
                    {
                        BalanceBox.Clear();
                        MessageBox.Show("No deposit or withdraw action done");
                        
                    }
                    break;
                }
            }
            abo.createBankAccount(aclsit);
            if(i == 1 )
                MessageBox.Show("Account Has Been Updated.", "Update Successful");
            else
                MessageBox.Show("Invalid Account Number.", "Error");

            textBoxAccNo.Clear();
            Holder1Box.Clear();
            Holder2Box.Clear();
            BalanceBox.Clear();
        }
        #endregion
        int flag = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
        }
    }
}
