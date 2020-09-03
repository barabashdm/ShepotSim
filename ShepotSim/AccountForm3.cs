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
    public partial class AccountForm3 : Form
    {
        public AccountForm3()
        {
            InitializeComponent();
            GetStructure();
            LoadDataForForm();
        }

        private ShepotSim.ApplicationContext db;

        public void GetStructure()
        {
            treeViewStructure.Nodes.Clear();
            db = new ShepotSim.ApplicationContext();
            List<User> listUser = db.Users.ToList();
            List<CheckPoint> listCheckPoint = db.CheckPoints.ToList();
            IEnumerable<User> listusr = listUser.Where((User m) => m.UserID.Equals(Data.Value));
            int i = -1;
            foreach (User usr in listusr)
            {
                if (usr.AdminPanel != true)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                }
                    Text = "СОЗ Шепот (учебный стенд)" + " - Вы авторизованы как " + usr.Surname + " " + usr.Name.Substring(0, 1) + ". " + usr.Patronymic.Substring(0, 1) + "., гр. " + usr.StudyGroup;
                    int j = -1;
                    foreach (User usr1 in listUser)
                    {
                        j++;
                        TreeNode treeNode = new TreeNode("гр. " + usr1.StudyGroup);
                        treeViewStructure.Nodes.Add(treeNode);
                        IEnumerable<User> listUser2 = listUser.Where((User m) => m.UserID.Equals(usr1.UserID));
                        int z = -1;
                        foreach (User usr2 in listUser2)
                        {
                            z++;
                            TreeNode subtreeNode = new TreeNode(usr2.Surname + " " + usr2.Name.Substring(0, 1) + ". " + usr2.Patronymic.Substring(0, 1));
                        subtreeNode.Tag = usr2.UserID;
                        treeViewStructure.Nodes[j].Nodes.Add(subtreeNode);
                    }
                    }
            }
        }

        private void treeViewStructure_DoubleClick(object sender, EventArgs e)
        {
            if (treeViewStructure.SelectedNode != null)
            {
                if (treeViewStructure.SelectedNode.Tag != null)
                {
                    DataExt.ValueExt = Convert.ToInt32(treeViewStructure.SelectedNode.Tag);
                }
            }
            ChangeAccountDataForm4 form4 = new ChangeAccountDataForm4();
            form4.ShowDialog();
        }

        private void LoadDataForForm()
        {
            List<User> listUser = db.Users.ToList();
            IEnumerable<User> listusr = listUser.Where((User m) => m.UserID.Equals(Data.Value));
            foreach (User usr in listusr)
            {
                tBSurname.Text = usr.Surname;
                tBName.Text = usr.Name;
                tBPatronymic.Text = usr.Patronymic;
                tBStudyGroup.Text = usr.StudyGroup;
                tbLogin.Text = usr.UserName;
                //tbPass.Text = usr.Password;
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
            {
                tbPass.UseSystemPasswordChar = true;
            }
            else
            {
                tbPass.UseSystemPasswordChar = false;
            }
        }

        private void cBShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBShowPass2.Checked)
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
                GetStructure();
                Program.f1.GetStructure();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<User> listUser = db.Users.ToList();
                User deleteUser = listUser.Find((User m) => m.UserID.Equals(Data.Value));
                db.Users.Remove(deleteUser);
                db.SaveChanges();

                //List<User> listUser = db.Users.ToList();
                User newUser = new User();
                newUser.UserID = listUser.Last().UserID + 1;
                newUser.StudyGroup = tBStudyGroup.Text;
                newUser.Surname = tBSurname.Text;
                newUser.Name = tBName.Text;
                newUser.Patronymic = tBPatronymic.Text;
                newUser.UserName = tbLogin.Text;
                newUser.Password = HashPassword(tbPass.Text, Convert.ToString(listUser.Last().UserID + 1));
                newUser.AdminPanel = checkBox3.Checked;

                db.Users.Add(newUser);
                db.SaveChanges();
                Program.f1.GetStructure();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeViewStructure.SelectedNode != null)
            {
                if (treeViewStructure.SelectedNode.Tag != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes)
                    {
                        return;
                    }
                    int level = treeViewStructure.SelectedNode.Level;
                    List<User> listUser = db.Users.ToList();
                    User deleteUser = listUser.Find((User m) => m.UserID.Equals(Convert.ToInt32(treeViewStructure.SelectedNode.Tag)));
                    db.Users.Remove(deleteUser);
                    db.SaveChanges();
                }
            }
            GetStructure();
            Program.f1.GetStructure();
        }
    }
}
