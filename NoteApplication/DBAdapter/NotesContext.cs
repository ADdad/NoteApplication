using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NoteApplication.Migrations;
using NoteApplication.Model;

namespace NoteApplication
{
    public class NotesContext : DbContext
    {
        public NotesContext() : base("dbConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NotesContext, Configuration>(true));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new User.UserEntityConfiguration());
            modelBuilder.Configurations.Add(new Note.NoteEntityConfiguration());
        }
    }
}