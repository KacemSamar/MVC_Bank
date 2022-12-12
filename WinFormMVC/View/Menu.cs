using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            new Clientfor().Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            new Adminform().Show();
        }

        private void Bank_Click(object sender, EventArgs e)
        {
            new BankForm().Show();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            new AccountForm().Show();
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
            new Formtrans().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
                    }
    }
}
