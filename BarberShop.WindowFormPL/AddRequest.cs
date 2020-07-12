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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();
        }


        bool flag1 = false,
            flag2 = false;

        private void label_fio_Click(object sender, EventArgs e)
        {

        }

        private void textBox_date_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_date.Text))
            {
                errorProvider_date.SetError(textBox_date, "Ошибка!!! Вы ничего не ввели!");
                flag2 = false;
            }
            else
            {
                flag2 = true;
                errorProvider_date.Clear();

            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (flag1 && flag2)
            {
                string[] data = new string[2];
                data[0] = textBox_fio.Text;

                data[1] = textBox_date.Text;


                Result_AddRequest frm = new Result_AddRequest(data);
                frm.Show();
                this.Close();
            }
        }

        private void textBox_fio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_fio.Text))
            {
                errorProvider_fio.SetError(textBox_fio, "Ошибка!!! Вы ничего не ввели!");
                flag1 = false;
            }
            else
            {
                flag1 = true;
                errorProvider_fio.Clear();

            }
        }
    }
}
