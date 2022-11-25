using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCsharp.Forms
{
    public partial class SignInFm : Form
    {
        public SignInFm()
        {
            InitializeComponent();
        }

        private void SetCancelButton(Button myCancelBtn)
        {
            this.CancelButton = myCancelBtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
