using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI_Bank
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Show Button
        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r2 = new StreamReader("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\NewBankAccount\\Account Input.txt");
                StreamWriter w2 = new StreamWriter("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\NewBankAccount\\Account Temp.txt");
                int f = 0;
                string temp;
                for (; ; )
                {
                    temp = r2.ReadLine();
                    if (temp == textBoxAccNo.Text)
                    {
                        w2.WriteLine(textBoxAccNo.Text);
                        w2.WriteLine(r2.ReadLine());
                        w2.WriteLine(r2.ReadLine());
                        w2.WriteLine(r2.ReadLine());
                        w2.WriteLine(r2.ReadLine());
                        w2.WriteLine(r2.ReadLine());
                        break;
                    }
                    else if (temp == null)
                    {
                        MessageBox.Show("Invalid Account Number", "Error");
                        f = 1;
                        break;
                    }
                }
                r2.Close();
                w2.Close();
                textBoxAccNo.Clear();
                if (f == 0)
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
            }
            catch { }
        }
        #endregion

    }
}
