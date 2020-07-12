using BarberShop.Common;
using BarderShop.BLL.Interface;
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
    public partial class GetAll : Form
    {
        public GetAll()
        {
            InitializeComponent();

            IBarberShopLogic RequestLogic = DependencyResolver.RequestLogic;

            if (RequestLogic.getAll() != null)
            {
                foreach (var item in RequestLogic.getAll())
                {
                    richTextBox1.Text += item + '\n';
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
