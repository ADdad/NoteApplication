using System;
using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;

namespace NoteApplication.Model
{
    [DataContract(IsReference = true)]
    public class Note
    {
        #region Fields

        [DataMember] private Guid _guid;
        [DataMember] private string _title;
        [DataMember] private string _text;
        [DataMember] private DateTime _createdDate;
        [DataMember] private DateTime _modifiedDate;
        [DataMember] private Guid _userGuid;
        [DataMember] private User _user;

        #endregion

        #region Properties

        public Guid Guid
        {
            get { return _guid; }
            private set { _guid = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        private DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; }
        }

        public Guid UserGuid
        {
            get { return _userGuid; }
            private set { _userGuid = value; }
        }

        public User User
        {
            get { return _user; }
            private set { _user = value; }
        }

        #endregion

        #region Constructor

        public Note(string title, string text, User user) : this()
        {
            _guid = Guid.NewGuid();
            _title = title;
            _text = text;
            _userGuid = user.Guid;
            _user = user;
            user.Notes.Add(this);
            _createdDate = DateTime.Now;
            _modifiedDate = DateTime.Now;
        }

        private Note()
        {
        }

        #endregion

        public override string ToString()
        {
            return Title;
        }

        #region EntityFrameworkConfiguration

        public class NoteEntityConfiguration : EntityTypeConfiguration<Note>
        {
            public NoteEntityConfiguration()
            {
                ToTable("Note");
                HasKey(s => s.Guid);

                Property(p => p.Guid)
                    .HasColumnName("Guid")
                    .IsRequired();
                Property(p => p.Title)
                    .HasColumnName("Title")
                    .IsRequired();
                Property(s => s.Text)
                    .HasColumnName("Text")
                    .IsRequired();
                Property(s => s.CreatedDate)
                    .HasColumnName("CreatedDate")
                    .IsRequired();
                Property(s => s.ModifiedDate)
                    .HasColumnName("ModifiedDate")
                    .IsRequired();
            }
        }

        #endregion

        public void DeleteDatabaseValues()
        {
            _user = null;
        }
    }
}