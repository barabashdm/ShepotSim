using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;

namespace ShepotSim
{
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();
        }

        private ShepotSim.ApplicationContext db;

        public static String HashPassword(string p, string s)
        {
            var combinedPassword = String.Concat(p, s);
            var sha256 = new SHA256Managed();
            var bytes = UTF8Encoding.UTF8.GetBytes(combinedPassword);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {

            db = new ShepotSim.ApplicationContext();
            List<User> listUser = db.Users.ToList();
            User user = listUser.Find((User m) => m.UserName.Equals(textBox_username.Text));
            if (user != null)
            {
                var pass = HashPassword(textBox_password.Text, Convert.ToString(user.UserID));
                if (textBox_username.Text == user.UserName & pass == user.Password)
                {
                    panel1.Height = 0;
                    label_Message.ForeColor = Color.Green;
                    label_Message.Text = "Авторизация успешна";
                    timer1.Start();
                    Data.Value = user.UserID;
                    Program.f1.GetStructure();
                }
                else
                {
                    panel1.Height = 0;
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Неверный логин или пароль";
                    timer1.Start();
                }
            }
            else
            {
                panel1.Height = 0;
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Запись не существует";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Height != 60)
            {
                panel1.Height = panel1.Height + 5;
                if (panel1.Height == 60)
                {
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Height != 0)
            {
                panel1.Height = panel1.Height - 5;
                if (panel1.Height == 0)
                {
                    timer2.Stop();
                }
            }
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
            {
                textBox_password.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = false;
            }
        }
    }
}
