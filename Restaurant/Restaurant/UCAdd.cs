using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class UCAdd : UserControl
    {
        Database database = new Database();
        String query;
        public UCAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            query = "insert into menu (nama, category, harga) values ('" + tbNama.Text + "','" + cbCategory.Text + "','" + tbHarga.Text + "' )";
            database.setData(query);
        }
        public void clearAll()
        {
            cbCategory.SelectedIndex = -1;
            tbNama.Clear();
            tbHarga.Clear();
        }

        private void UCAdd_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

