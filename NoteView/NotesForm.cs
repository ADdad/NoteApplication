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
            NotesForm_Shown(null, null);
        }

        public NotesForm(string UserLogin)
        {
            SetUserLogin(UserLogin);
            InitializeComponent();
            NotesForm_Shown(null, null);
        }

        private string UserLogin;

        public void SetUserLogin(string login)
        {
            UserLogin = login;
        }


        private void NotesForm_Shown(object sender, System.EventArgs e)
        {
            Control fullName = Controls.Find("FullNameLabel", true)[0];
            NotesService.INoteService ns = new NoteServiceClient();
            User user1 = ns.GetUserByLogin(UserLogin);
            user = user1;
            fullName.Text = user1._firstName + " " + user1._lastName;

            ListBox listBox = (ListBox)Controls.Find("ListNotes", true)[0];
            
            List<Note> notes = ns.getAllNotes(user._guid).ToList();
            foreach (var note in notes)
            {
                listBox.Items.Add(new MyObject(note._title, note._guid));
            }
            
        }

        private void UpdateNotes()
        {
            NotesService.INoteService ns = new NoteServiceClient();
            ListBox listBox = (ListBox)Controls.Find("ListNotes", true)[0];
            listBox.Items.Clear();
            List<Note> notes = ns.getAllNotes(user._guid).ToList();
            foreach (var note in notes)
            {
                listBox.Items.Add(new MyObject(note._title, note._guid));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedNote._title = NoteTitle.Text;
            selectedNote._text = NoteText.Text;
            NotesService.INoteService ns = new NoteServiceClient();
            ns.SaveNote(selectedNote);
            UpdateNotes();
        }

        private User user;

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)Controls.Find("ListNotes", true)[0];

            NotesService.INoteService ns = new NoteServiceClient();
            Note newNote = ns.AddNote(user);
            listBox.Items.Add(new MyObject("Title", newNote._guid));
            UpdateNotes();
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

        

        
        private void button3_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private Note selectedNote = null;

        private void ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyObject item = ListNotes.SelectedItems[0] as MyObject; 
            if (item != null)
            {
                NotesService.INoteService ns = new NoteServiceClient();
                selectedNote = ns.GetNote(item.value);
                NoteText.Text = selectedNote._text;
                NoteTitle.Text = selectedNote._title;
                // use item here
            }

            UpdateNotes();
        }

        private void NoteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotesService.INoteService ns = new NoteServiceClient();
            ns.DeleteNote(selectedNote);
            UpdateNotes();
        }
    }
}
