using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            lbl_error.Visible=false;
            bool pr = true;
            string password = "";
            if (lbl1.Text == string.Empty)
            {
                lbl_error.Visible= true;
                lbl_error.Text = "Введите логин";
                return;
            }
            else if (lbl2.Text==string.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите пароль";
                return;
            }
            else
            {
                KL kL = new KL();
                kL.SignIn(tb1.Text,out  password, out pr);
                if (tb2.Text==password&&pr==true)
                {
                    MessageBox.Show("Авторизация прошла успешна");
                }
                else { MessageBox.Show("Неверный логин или пароль"); }
            }
        }
    }
}
