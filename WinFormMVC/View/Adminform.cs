using MVCController;
using MVCModal;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        AdminADO c = new AdminADO();
           
        private void add_Click(object sender, EventArgs e)
        {
            adminBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Admin cl = adminBindingSource.Current as Admin;
            c.insert(cl);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Admin cl = adminBindingSource.Current as Admin;
            c.delete(cl);
            adminBindingSource.RemoveCurrent();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Admin cl = adminBindingSource.Current as Admin;
            c.update(cl);
        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            c.load();
            adminBindingSource.DataSource = c.AdminADOList;
        }
    }
}
