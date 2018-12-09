using System.Collections.Generic;
using System.Linq;

namespace NoteApplication
{
    public class NoteService : INoteService
    {
        public IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();
            NotesContext nc = new NotesContext();
            users = nc.Users.ToList();
            return users;
        }

        public void AddUser(User user)
        {
            NotesContext nc = new NotesContext();
            nc.Users.Add(user);
            nc.SaveChanges();
        }

        public void UpdateUser(User userObj)
        {
            NotesContext nc = new NotesContext();
            var c = (from user in nc.Users
                where user.Id == userObj.Id
                select user).First();
            c.Email = userObj.Email;
            c.FirstName = userObj.FirstName;
            c.SecondName = userObj.SecondName;
            nc.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            NotesContext nc = new NotesContext();
            var c = (from user in nc.Users
                where user.Id == Id
                select user).First();
            nc.Users.Remove(c);
            nc.SaveChanges();
        }
    }
}