using System.ComponentModel;
using System.Runtime.CompilerServices;
using KMA.APZRPMJ2018.WalletSimulator.Models;
using KMA.APZRPMJ2018.WalletSimulator.Properties;

namespace KMA.APZRPMJ2018.WalletSimulator.ViewModels
{
    internal class NoteConfigurationViewModel : INotifyPropertyChanged
    {
        #region Fields
        private readonly Note _currentNote;
        #endregion

        #region Properties

        public string Title
        {
            get { return _currentNote.Title; }
            set
            {
                _currentNote.Title = value;
                OnPropertyChanged();
            }
        }

        public string Text
        {
            get { return _currentNote.Text; }
            set
            {
                _currentNote.Text = value;
                OnPropertyChanged();
            }
        }

        #endregion



        #region Constructor
        public NoteConfigurationViewModel(Note note)
        {
            _currentNote = note;
        }
        #endregion
        #region EventsAndHandlers
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion


    }
}
