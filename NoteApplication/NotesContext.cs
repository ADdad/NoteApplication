using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NoteApplication
{
    public class NotesContext : DbContext
    {
        public NotesContext() : base("dbConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}