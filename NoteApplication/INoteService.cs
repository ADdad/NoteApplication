using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NoteApplication
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "INoteService" в коде и файле конфигурации.
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        IEnumerable<User> GetUsers();
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void UpdateUser(User user);
        [OperationContract]
        void DeleteUser(int id);

    }

    [DataContract]
    public class User
    {
        [DataMember]
        [Key]
        [Required]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Email { get; set; }
        [DataMember]
        [Required]
        public string Password { get; set; }
        [DataMember]
        [Required]
        public string FirstName { get; set; }
        [DataMember]
        [Required]
        public string SecondName { get; set; }
        //public virtual ICollection<Note> Notes { get; set; }
    }

}
