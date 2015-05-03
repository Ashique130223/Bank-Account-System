using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BO
{
    public class AccountBO
    {
        MakeBankAccount m = new MakeBankAccount();
        
        public bool createBankAccount(List<Account> a)
        {
            return m.createBankAccount(a);
        }

        public void readBankAccount(List<Account> ar)
        {
            m.readBankAccount(ar);
        }

    }
}
