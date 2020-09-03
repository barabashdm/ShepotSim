using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ShepotSim
{
    public partial class ChangeAccountDataForm4 : Form
    {
        public ChangeAccountDataForm4()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox7.UseSystemPasswordChar = true;
            }
            else
            {
                textBox7.UseSystemPasswordChar = false;
            }
        }

        public static String HashPassword(string p, string s)
        {
            var combinedPassword = String.Concat(p, s);
            var sha256 = new SHA256Managed();
            var bytes = UTF8Encoding.UTF8.GetBytes(combinedPassword);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<User> listUser = db.Users.ToList();
                User deleteUser = listUser.Find((User m) => m.UserID.Equals(DataExt.ValueExt));
                db.Users.Remove(deleteUser);
                db.SaveChanges();

                //List<User> listUser = db.Users.ToList();
                User newUser = new User();
                newUser.UserID = listUser.Last().UserID + 1;
                newUser.StudyGroup = textBox3.Text;
                newUser.Surname = textBox6.Text;
                newUser.Name = textBox5.Text;
                newUser.Patronymic = textBox4.Text;
                newUser.UserName = textBox8.Text;
                newUser.Password = HashPassword(textBox7.Text, Convert.ToString(listUser.Last().UserID + 1));
                newUser.AdminPanel = checkBox3.Checked;

                db.Users.Add(newUser);
                db.SaveChanges();
                Program.f1.GetStructure();
                Program.f3.GetStructure();
            }
        }
    }
}
