﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoteView.NotesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/NoteApplication.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid _guidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime _lastLoginDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _loginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NoteView.NotesService.Note[] _notesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _passwordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _email {
            get {
                return this._emailField;
            }
            set {
                if ((object.ReferenceEquals(this._emailField, value) != true)) {
                    this._emailField = value;
                    this.RaisePropertyChanged("_email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _firstName {
            get {
                return this._firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this._firstNameField, value) != true)) {
                    this._firstNameField = value;
                    this.RaisePropertyChanged("_firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid _guid {
            get {
                return this._guidField;
            }
            set {
                if ((this._guidField.Equals(value) != true)) {
                    this._guidField = value;
                    this.RaisePropertyChanged("_guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime _lastLoginDate {
            get {
                return this._lastLoginDateField;
            }
            set {
                if ((this._lastLoginDateField.Equals(value) != true)) {
                    this._lastLoginDateField = value;
                    this.RaisePropertyChanged("_lastLoginDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _lastName {
            get {
                return this._lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this._lastNameField, value) != true)) {
                    this._lastNameField = value;
                    this.RaisePropertyChanged("_lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _login {
            get {
                return this._loginField;
            }
            set {
                if ((object.ReferenceEquals(this._loginField, value) != true)) {
                    this._loginField = value;
                    this.RaisePropertyChanged("_login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NoteView.NotesService.Note[] _notes {
            get {
                return this._notesField;
            }
            set {
                if ((object.ReferenceEquals(this._notesField, value) != true)) {
                    this._notesField = value;
                    this.RaisePropertyChanged("_notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _password {
            get {
                return this._passwordField;
            }
            set {
                if ((object.ReferenceEquals(this._passwordField, value) != true)) {
                    this._passwordField = value;
                    this.RaisePropertyChanged("_password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Note", Namespace="http://schemas.datacontract.org/2004/07/NoteApplication.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Note : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime _createdDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid _guidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime _modifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _textField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NoteView.NotesService.User _userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid _userGuidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime _createdDate {
            get {
                return this._createdDateField;
            }
            set {
                if ((this._createdDateField.Equals(value) != true)) {
                    this._createdDateField = value;
                    this.RaisePropertyChanged("_createdDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid _guid {
            get {
                return this._guidField;
            }
            set {
                if ((this._guidField.Equals(value) != true)) {
                    this._guidField = value;
                    this.RaisePropertyChanged("_guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime _modifiedDate {
            get {
                return this._modifiedDateField;
            }
            set {
                if ((this._modifiedDateField.Equals(value) != true)) {
                    this._modifiedDateField = value;
                    this.RaisePropertyChanged("_modifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _text {
            get {
                return this._textField;
            }
            set {
                if ((object.ReferenceEquals(this._textField, value) != true)) {
                    this._textField = value;
                    this.RaisePropertyChanged("_text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _title {
            get {
                return this._titleField;
            }
            set {
                if ((object.ReferenceEquals(this._titleField, value) != true)) {
                    this._titleField = value;
                    this.RaisePropertyChanged("_title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NoteView.NotesService.User _user {
            get {
                return this._userField;
            }
            set {
                if ((object.ReferenceEquals(this._userField, value) != true)) {
                    this._userField = value;
                    this.RaisePropertyChanged("_user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid _userGuid {
            get {
                return this._userGuidField;
            }
            set {
                if ((this._userGuidField.Equals(value) != true)) {
                    this._userGuidField = value;
                    this.RaisePropertyChanged("_userGuid");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NotesService.INoteService")]
    public interface INoteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/AddUser", ReplyAction="http://tempuri.org/INoteService/AddUserResponse")]
        void AddUser(string[] UserParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/AddUser", ReplyAction="http://tempuri.org/INoteService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string[] UserParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/UserExists", ReplyAction="http://tempuri.org/INoteService/UserExistsResponse")]
        bool UserExists(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/UserExists", ReplyAction="http://tempuri.org/INoteService/UserExistsResponse")]
        System.Threading.Tasks.Task<bool> UserExistsAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/GetUserByLogin", ReplyAction="http://tempuri.org/INoteService/GetUserByLoginResponse")]
        NoteView.NotesService.User GetUserByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/GetUserByLogin", ReplyAction="http://tempuri.org/INoteService/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<NoteView.NotesService.User> GetUserByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/CheckPassword", ReplyAction="http://tempuri.org/INoteService/CheckPasswordResponse")]
        bool CheckPassword(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/CheckPassword", ReplyAction="http://tempuri.org/INoteService/CheckPasswordResponse")]
        System.Threading.Tasks.Task<bool> CheckPasswordAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/AddNote", ReplyAction="http://tempuri.org/INoteService/AddNoteResponse")]
        NoteView.NotesService.Note AddNote(NoteView.NotesService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/AddNote", ReplyAction="http://tempuri.org/INoteService/AddNoteResponse")]
        System.Threading.Tasks.Task<NoteView.NotesService.Note> AddNoteAsync(NoteView.NotesService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/DeleteNote", ReplyAction="http://tempuri.org/INoteService/DeleteNoteResponse")]
        void DeleteNote(NoteView.NotesService.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/DeleteNote", ReplyAction="http://tempuri.org/INoteService/DeleteNoteResponse")]
        System.Threading.Tasks.Task DeleteNoteAsync(NoteView.NotesService.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/getAllNotes", ReplyAction="http://tempuri.org/INoteService/getAllNotesResponse")]
        NoteView.NotesService.Note[] getAllNotes(System.Guid userGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/getAllNotes", ReplyAction="http://tempuri.org/INoteService/getAllNotesResponse")]
        System.Threading.Tasks.Task<NoteView.NotesService.Note[]> getAllNotesAsync(System.Guid userGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/GetNote", ReplyAction="http://tempuri.org/INoteService/GetNoteResponse")]
        NoteView.NotesService.Note GetNote(System.Guid noteGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/GetNote", ReplyAction="http://tempuri.org/INoteService/GetNoteResponse")]
        System.Threading.Tasks.Task<NoteView.NotesService.Note> GetNoteAsync(System.Guid noteGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/SaveNote", ReplyAction="http://tempuri.org/INoteService/SaveNoteResponse")]
        void SaveNote(NoteView.NotesService.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INoteService/SaveNote", ReplyAction="http://tempuri.org/INoteService/SaveNoteResponse")]
        System.Threading.Tasks.Task SaveNoteAsync(NoteView.NotesService.Note note);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INoteServiceChannel : NoteView.NotesService.INoteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NoteServiceClient : System.ServiceModel.ClientBase<NoteView.NotesService.INoteService>, NoteView.NotesService.INoteService {
        
        public NoteServiceClient() {
        }
        
        public NoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUser(string[] UserParams) {
            base.Channel.AddUser(UserParams);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string[] UserParams) {
            return base.Channel.AddUserAsync(UserParams);
        }
        
        public bool UserExists(string login) {
            return base.Channel.UserExists(login);
        }
        
        public System.Threading.Tasks.Task<bool> UserExistsAsync(string login) {
            return base.Channel.UserExistsAsync(login);
        }
        
        public NoteView.NotesService.User GetUserByLogin(string login) {
            return base.Channel.GetUserByLogin(login);
        }
        
        public System.Threading.Tasks.Task<NoteView.NotesService.User> GetUserByLoginAsync(string login) {
            return base.Channel.GetUserByLoginAsync(login);
        }
        
        public bool CheckPassword(string login, string password) {
            return base.Channel.CheckPassword(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPasswordAsync(string login, string password) {
            return base.Channel.CheckPasswordAsync(login, password);
        }
        
        public NoteView.NotesService.Note AddNote(NoteView.NotesService.User user) {
            return base.Channel.AddNote(user);
        }
        
        public System.Threading.Tasks.Task<NoteView.NotesService.Note> AddNoteAsync(NoteView.NotesService.User user) {
            return base.Channel.AddNoteAsync(user);
        }
        
        public void DeleteNote(NoteView.NotesService.Note note) {
            base.Channel.DeleteNote(note);
        }
        
        public System.Threading.Tasks.Task DeleteNoteAsync(NoteView.NotesService.Note note) {
            return base.Channel.DeleteNoteAsync(note);
        }
        
        public NoteView.NotesService.Note[] getAllNotes(System.Guid userGuid) {
            return base.Channel.getAllNotes(userGuid);
        }
        
        public System.Threading.Tasks.Task<NoteView.NotesService.Note[]> getAllNotesAsync(System.Guid userGuid) {
            return base.Channel.getAllNotesAsync(userGuid);
        }
        
        public NoteView.NotesService.Note GetNote(System.Guid noteGuid) {
            return base.Channel.GetNote(noteGuid);
        }
        
        public System.Threading.Tasks.Task<NoteView.NotesService.Note> GetNoteAsync(System.Guid noteGuid) {
            return base.Channel.GetNoteAsync(noteGuid);
        }
        
        public void SaveNote(NoteView.NotesService.Note note) {
            base.Channel.SaveNote(note);
        }
        
        public System.Threading.Tasks.Task SaveNoteAsync(NoteView.NotesService.Note note) {
            return base.Channel.SaveNoteAsync(note);
        }
    }
}
