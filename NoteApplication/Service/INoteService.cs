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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "INoteService" в коде и файле конфигурации.
    [ServiceContract]
    public interface INoteService
    {

        [OperationContract]
        bool UserExists(string login);
        [OperationContract]
        User GetUserByLogin(string login);
        [OperationContract]
        User GetUserByGuid(Guid guid);
        [OperationContract]
        List<User> GetAllUsers(Guid walletGuid);
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void AddNote(Note wallet);
        [OperationContract]
        void SaveNote(Note wallet);
        [OperationContract]
        void DeleteNote(Note selectedNote);

    }


}
