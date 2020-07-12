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
    public partial class Result_AddRequest : Form
    {
        public Result_AddRequest(string[] arrStr)
        {
            InitializeComponent();

            IBarberShopLogic RequestLogic = DependencyResolver.RequestLogic;

            try
            {
                RequestLogic.addRequest(arrStr[0], DateTime.Parse(arrStr[1]));
                label_resultAdding.Text = "Запись добавлена!";

            }
            catch (Exception)
            {
                this.Text = "ERROR";
                Color redColor = Color.FromArgb(255, 0, 0);
                label_resultAdding.ForeColor = redColor;

                label_resultAdding.Text = "Ошибка!!! Не верный формат даты";

            }
        }

        private void button_okok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
