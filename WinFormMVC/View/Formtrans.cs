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
    public partial class Formtrans : Form
    {
        public Formtrans()
        {
            InitializeComponent();
        }
        TransactionADO t = new TransactionADO();
        AccountADO a = new AccountADO();
        private void Formtrans_Load(object sender, EventArgs e)
        {
            t.load();
            a.load();
            transactionBindingSource.DataSource = t.TransactionADOList;
            accountBindingSource.DataSource = a.AccountADOList;
            Console.WriteLine(a.AccountADOList.Count);
        }

        private void add_Click(object sender, EventArgs e)
        {
            transactionBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Transaction tr = transactionBindingSource.Current as Transaction;
            if (!t.insert(tr))
                MessageBox.Show("insuffaisant");

            
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Transaction tr = transactionBindingSource.Current as Transaction;
            t.update(tr);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Transaction tr = transactionBindingSource.Current as Transaction;
            t.delete(tr);
            transactionBindingSource.RemoveCurrent();
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
