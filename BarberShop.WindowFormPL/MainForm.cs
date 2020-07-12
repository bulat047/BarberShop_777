using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop.WindowFormPL
{
    public partial class MainForm : Form
    {
        public MainForm(string name)
        {
            InitializeComponent();
            label_nameUser.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_addRequest_Click(object sender, EventArgs e)
        {
            AddRequest frm = new AddRequest();
            frm.Show();
        }

        private void button_getAll_Click(object sender, EventArgs e)
        {
            GetAll frm = new GetAll();
            frm.Show();
        }
    }
}
