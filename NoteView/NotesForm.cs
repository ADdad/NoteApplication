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
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, System.EventArgs e)
        {
            Control fullName = Controls.Find("FullNameLabel", true)[0];
            NotesService.INoteService ns = new NoteServiceClient();
            User user = ns.GetUserByLogin(UserLogin);
            fullName.Text = user._firstName + " " + user._lastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)Controls.Find("ListNotes", true)[0];
            
        }

        private class MyObject
        {
            public Guid value { get; set; }
            public string name { get; set; }
            public MyObject(string name, Guid value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString() { return this.name; }
        }

        private string UserLogin;

        public void SetUserLogin(string login)
        {
            UserLogin = login;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
    }
}
