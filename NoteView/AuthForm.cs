using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteView.NotesService;

namespace NoteView
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        void AlertMessage(string message)
        {
            Control alert = Controls.Find("ValidationLabel", true)[0];
            alert.Text = message;
            alert.Visible = true;
        }

        void GoToRegistration()
        {
            RegForm reg = new RegForm();
            reg.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            GoToRegistration();
        }

        void LoginUser(string login)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.SetUserLogin(login);
            notesForm.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool validation = true;

            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("LoginBox", true)[0]).Text)) validation = false;
            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("PasswordBox", true)[0]).Text)) validation = false;
            if (!validation) AlertMessage("Fill all fields");
            else
            {
                string Login = ((TextBox) this.Controls.Find("LoginBox", true)[0]).Text;
                string Password = ((TextBox) this.Controls.Find("PasswordBox", true)[0]).Text;
                NoteServiceClient ns = new NoteServiceClient();
                if (!ns.UserExists(Login)) AlertMessage("Wrong login");
                else
                {
                    if (!ns.CheckPassword(Login, Password)) AlertMessage("Wrong password");
                    else LoginUser(Login);
                }
            }
        }
    }
}