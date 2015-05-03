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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\NewBankAccount\\Account Temp.txt");
            try
            {
                labelAcNo.Text = r.ReadLine();
                labelHolder1.Text = r.ReadLine();
                labelHolder2.Text = r.ReadLine();
                labelBalance.Text = r.ReadLine();
                labelBank.Text = r.ReadLine();
                labelBranch.Text = r.ReadLine();
                r.Close();
            }
            catch { }
        }

    }
}
