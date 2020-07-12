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

    public partial class AuthorizationUser : Form
    {
        public AuthorizationUser()
        {
            InitializeComponent();
        }

        bool flag = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_authorization_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MainForm frm = new MainForm(textBox_authorization.Text);
                frm.Show();

               // this.Close();
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void textBox_authorization_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_authorization.Text))
            {
                errorProvider_name.SetError(textBox_authorization, "Ошибка!!! Вы ничего не ввели!");
                flag = false;
            }
            else
            {
                flag = true;
                errorProvider_name.Clear();

            }
        }
    }
}
