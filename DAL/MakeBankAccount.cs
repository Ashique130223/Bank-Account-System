using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class MakeBankAccount
    {
        #region createBankAccount
        public bool createBankAccount(List<Account> a)
        {
            StreamWriter w1 = new StreamWriter("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\NewBankAccount\\Account Input.txt");
            try
            {
                for (int i = 0; i < a.Count(); i++)
                {
                    w1.WriteLine(a[i].accountNumber);
                    w1.WriteLine(a[i].holderName1);
                    w1.WriteLine(a[i].holderName2);
                    w1.WriteLine(Convert.ToString(a[i].balance));
                    w1.WriteLine(a[i].bankName);
                    w1.WriteLine(a[i].bankBranch);
                }
                w1.Close();
                return true;
            }
            catch(Exception e1)
            {
                return false;
            }
        }
        #endregion

        #region readBankAccount
        public void readBankAccount(List<Account> ar)
        {
            try
            {
                StreamReader r1 = new StreamReader("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\NewBankAccount\\Account Input.txt");
                string temp = r1.ReadLine();
                while(temp != null)
                {
                    Account ac = new Account();
                    ac.accountNumber = temp;
                    ac.holderName1 = r1.ReadLine();
                    ac.holderName2 = r1.ReadLine();
                    ac.balance = Convert.ToDouble(r1.ReadLine());
                    ac.bankName = r1.ReadLine();
                    ac.bankBranch = r1.ReadLine();
                    ar.Add(ac);
                    temp = r1.ReadLine();
                }
                r1.Close();
            }
            catch { }
        }
        #endregion
    }
}
