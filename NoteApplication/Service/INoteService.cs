using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NoteApplication.Model;

namespace NoteApplication
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        void AddUser(List<string> UserParams);

        [OperationContract]
        bool UserExists(string login);

        [OperationContract]
        User GetUserByLogin(string login);

        [OperationContract]
        bool CheckPassword(string login, string password);

        [OperationContract]
        Note AddNote(User user);

        [OperationContract]
        void DeleteNote(Note note);

        [OperationContract]
        List<Note> getAllNotes(Guid userGuid);

        [OperationContract]
        Note GetNote(Guid noteGuid);

        [OperationContract]
        void SaveNote(Note note);
    }
}