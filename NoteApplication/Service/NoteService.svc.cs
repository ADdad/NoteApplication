using System;
using System.Collections.Generic;
using System.Linq;
using NoteApplication.DBAdapter;
using NoteApplication.Model;

namespace NoteApplication
{
    public class NoteService : INoteService
    {
        public void AddUser(List<string> UserParams)
        {
            if (UserParams.Count == 5)
            {
                User user = new User(UserParams[0], UserParams[1], UserParams[2], UserParams[3], UserParams[4]);
                EntityWrapper.AddUser(user);
            }
        }


        public bool UserExists(string login)
        {
            return EntityWrapper.UserExists(login);
        }

        public User GetUserByLogin(string login)
        {
            return EntityWrapper.GetUserByLogin(login);
        }

        public bool CheckPassword(string login, string password)
        {
            User user = EntityWrapper.GetUserByLogin(login);
            return user.CheckPassword(password);
        }

        public Note AddNote(User user)
        {
            return EntityWrapper.AddNote(new Note("Title", "", user));
        }

        public void DeleteNote(Note note)
        {
            EntityWrapper.DeleteNote(note);
        }

        public List<Note> getAllNotes(Guid userGuid)
        {
            return EntityWrapper.GetAllNotes(userGuid);
        }

        public Note GetNote(Guid noteGuid)
        {
            return EntityWrapper.GetNoteById(noteGuid);
        }

        public void SaveNote(Note note)
        {
            EntityWrapper.SaveNote(note);
        }
    }
}