using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCController;
using MVCModal;

namespace View
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            accountTableAdapter1.Fill(examDataSet11.account);
        }
        AccountADO a = new AccountADO();   
        BankADO b = new BankADO();
        private void add_Click(object sender, EventArgs e)
        {
            accountBindingSource.AddNew();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Account ac= accountBindingSource.Current as Account;
            a.update(ac);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Account ac = accountBindingSource.Current as Account;
            a.insert(ac);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Account ac = accountBindingSource.Current as Account;
            a.delete(ac);
            accountBindingSource.RemoveCurrent();

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            a.load();
            b.load();
            accountBindingSource.DataSource = a.AccountADOList;
            bankBindingSource.DataSource = b.BankADOList;
        }
    }
}
