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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ReturnToLoginPage();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        void AlertMessage()
        {
            Controls.Find("ValidationLabel", true)[0].Visible = true;
        }

        void CreateUser()
        {
            NotesService.INoteService service = new NotesService.NoteServiceClient();
            List<string> UserParams = new List<string>();
            UserParams.Add((((TextBox) this.Controls.Find("FirstNameBox", true)[0]).Text));
            UserParams.Add((((TextBox) this.Controls.Find("SecondNameBox", true)[0]).Text));
            UserParams.Add((((TextBox) this.Controls.Find("EmailBox", true)[0]).Text));
            UserParams.Add((((TextBox) this.Controls.Find("LoginBox", true)[0]).Text));
            UserParams.Add((((TextBox) this.Controls.Find("PasswordBox", true)[0]).Text));
            service.AddUser(UserParams.ToArray());
            ReturnToLoginPage();
        }

        void ReturnToLoginPage()
        {
            AuthForm auth = new AuthForm();
            auth.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool validation = true;
            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("LoginBox", true)[0]).Text))
            {
                validation = false;
            }

            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("PasswordBox", true)[0]).Text))
            {
                validation = false;
            }

            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("EmailBox", true)[0]).Text))
            {
                validation = false;
            }

            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("FirstNameBox", true)[0]).Text))
            {
                validation = false;
            }

            if (string.IsNullOrEmpty(((TextBox) this.Controls.Find("SecondNameBox", true)[0]).Text))
            {
                validation = false;
            }

            if (validation == false) this.AlertMessage();
            else
            {
                this.CreateUser();
                
            }
        }

        private void ValidationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}