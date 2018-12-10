using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NoteApplication.Model;

namespace NoteApplication.DBAdapter
{
    public static class EntityWrapper
    {
        public static bool UserExists(string login)
        {
            using (var context = new NotesContext())
            {
                return context.Users.Any(u => u.Login == login);
            }
        }

        public static User GetUserByLogin(string login)
        {
            using (var context = new NotesContext())
            {
                return context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Login == login);
            }
        }

        public static Note GetNoteById(Guid noteGuid)
        {
            using (var context = new NotesContext())
            {
                return context.Notes.FirstOrDefault(u => u.Guid == noteGuid);
            }
        }


        public static User GetUserByGuid(Guid guid)
        {
            using (var context = new NotesContext())
            {
                return context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Guid == guid);
            }
        }

        public static List<User> GetAllUsers(Guid noteGuid)
        {
            using (var context = new NotesContext())
            {
                return context.Users.Where(u => u.Notes.All(r => r.Guid != noteGuid)).ToList();
            }
        }

        public static List<Note> GetAllNotes(Guid userGuid)
        {
            using (var context = new NotesContext())
            {
                return context.Notes.Where(u => u.User.Guid == userGuid).ToList();
            }
        }

        public static void AddUser(User user)
        {
            using (var context = new NotesContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static Note AddNote(Note note)
        {
            using (var context = new NotesContext())
            {
                note.DeleteDatabaseValues();
                context.Notes.Add(note);
                context.SaveChanges();
            }

            return note;
        }


        public static void SaveNote(Note note)
        {
            using (var context = new NotesContext())
            {
                context.Entry(note).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void DeleteNote(Note selectedNote)
        {
            using (var context = new NotesContext())
            {
                selectedNote.DeleteDatabaseValues();
                context.Notes.Attach(selectedNote);
                context.Notes.Remove(selectedNote);
                context.SaveChanges();
            }
        }
    }
}