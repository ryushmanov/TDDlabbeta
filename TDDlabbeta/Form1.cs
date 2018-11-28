using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TDDlabbeta
{
    public partial class Form1 : Form
    {
        private string[,] loginpass;
        private string[] users;
        private string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUser(object sender, EventArgs e)
        {
            passerr.Visible = false;
            loginerr.Visible = false;
            bool err = false;
            err = EmptyCheck();
            if (err == false)
            {
                for (int i = 0; i < loginpass.GetLength(0); i++)
                {
                    if (loginpass[i, 0].Equals(login.Text))
                    {
                        err = true;
                        loginerr.Visible = true;
                        toolTip.SetToolTip(loginerr, "Такой логин уже существует");
                        break;
                    }
                }
            }
            if (err == false)
            {
                string s = login.Text + "\t" + PassHash(pass.Text);
                AddLine(s);
                MessageBox.Show("Пользователь успешно добавлен", "Добавление пользователя", MessageBoxButtons.OK);
                GetUsers();
            }
        }
        private void LoginUser(object sender, EventArgs e)
        {
            passerr.Visible = false;
            loginerr.Visible = false;
            if (UserCheck() != -1)
                MessageBox.Show("Логин и пароль успешно подтверждены", "Проверка правильности", MessageBoxButtons.OK);
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            passerr.Visible = false;
            loginerr.Visible = false;
            int userindex = UserCheck();
            if (userindex != -1)
            {
                RemoveLine(userindex);
                MessageBox.Show("Пользователь успешно удален", "Удаление пользователя", MessageBoxButtons.OK);
                GetUsers();
            }
        }
        private void FindFile(object sender, EventArgs e)
        {
            if (pathTextBox.Text != "")
            {
                path = @"" + pathTextBox.Text + ".txt";
                if (File.Exists(path))
                {
                    GetUsers();
                    AddButton.Enabled = true;
                    LoginButton.Enabled = true;
                    DelButton.Enabled = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл с указанным именем не найден. Создать файл?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes && PathCheck(path) == false)
                    {
                        File.Create(path).Close();
                        MessageBox.Show("Файл " + path + " успешно создан", "Создание файла", MessageBoxButtons.OK);
                        GetUsers();
                        AddButton.Enabled = true;
                        LoginButton.Enabled = true;
                        DelButton.Enabled = true;
                    }
                    else
                    {
                        AddButton.Enabled = false;
                        LoginButton.Enabled = false;
                        DelButton.Enabled = false;
                    }
                }
            }
            else
            {
                patherr.Visible = true;
                toolTip.SetToolTip(patherr, "Введите имя файла");
            }
        }

        private bool EmptyCheck()
        {
            bool err = false;
            if (login.Text == "")
            {
                err = true;
                loginerr.Visible = true;
                toolTip.SetToolTip(loginerr, "Введите логин");
            }
            if (pass.Text == "")
            {
                err = true;
                passerr.Visible = true;
                toolTip.SetToolTip(passerr, "Введите пароль");
            }
            return err;
        }
        private int UserCheck()
        {
            int index = -1;
            bool err = false;
            bool loginxst = false;
            err = EmptyCheck();
            string password = PassHash(pass.Text);
            if (err == false)
            {
                for (int i = 0; i < loginpass.GetLength(0); i++)
                {
                    if (loginpass[i, 0].Equals(login.Text))
                    {
                        loginxst = true;
                        if (!loginpass[i, 1].Equals(password))
                        {
                            passerr.Visible = true;
                            toolTip.SetToolTip(passerr, "Введен неправильный пароль");
                            break;
                        }
                        else
                        {
                            index = i;
                            break;
                        }
                    }
                }
                if (loginxst == false)
                {
                    loginerr.Visible = true;
                    toolTip.SetToolTip(loginerr, "Введен неправильный логин");
                }
            }
            return index;
        }
        private bool PathCheck(string path)
        {
            bool err = false;
            char[] invalidFileChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidFileChars)
            {
                if (path.Contains(c))
                {
                    err = true;
                    MessageBox.Show("Имя файла не должно содержать следующих знаков: \\ / : * ? \" < > |", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return err;
        }
        private void pass_TextChanged(object sender, EventArgs e)
        {
            passerr.Visible = false;
        }
        private void login_TextChanged(object sender, EventArgs e)
        {
            loginerr.Visible = false;
        }
        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            patherr.Visible = false;
        }
        private void GetUsers()
        {
            users = File.ReadAllLines(path);
            loginpass = new string[users.Length, 2];
            for(int i = 0; i < users.Length; i++)
            {
                loginpass[i, 0] = users[i].Split('\t')[0];
                loginpass[i, 1] = users[i].Split('\t')[1];
            }
        }
        private void AddLine(string s)
        {
            StreamWriter encoded = new StreamWriter(path, true);
            encoded.WriteLine(s);
            encoded.Close();
        }
        private void RemoveLine(int user)
        {
            string[] delete = new string[users.Length - 1];
            users[user] = users[users.Length - 1];
            for(int i = 0; i < delete.Length; i++)
            {
                delete[i] = users[i];
            }
            File.WriteAllLines(path, delete);
        }
        private string PassHash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }
    }
}
