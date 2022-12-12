using MVCController;
using MVCModal;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class Clientfor : Form
    {
        public Clientfor()
        {
            InitializeComponent();
        }

        ClientADO c = new ClientADO();
     

        private void Clientfor_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'eXAMDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           c.load();
           clientBindingSource.DataSource = c.clientADOList;  
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Client cl =clientBindingSource.Current as Client;
            c.insert(cl);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Client cl = clientBindingSource.Current as Client;
            c.delete(cl);
            clientBindingSource.RemoveCurrent();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Client cl = clientBindingSource.Current as Client;
            c.update(cl);
        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
