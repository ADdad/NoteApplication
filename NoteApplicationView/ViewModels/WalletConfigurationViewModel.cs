using System.ComponentModel;
using System.Runtime.CompilerServices;
using NoteApplicationView.Managers;
using NoteApplicationView.Models;
using NoteApplicationView.Properties;

namespace NoteApplicationView.ViewModels
{
    internal class WalletConfigurationViewModel : INotifyPropertyChanged
    {
        #region Fields
        private readonly WalletUIModel _currentWallet;
        #endregion

        #region Properties
        
        public string Title
        {
            get { return _currentWallet.Title; }
            set
            {
                _currentWallet.Title = value;
                OnPropertyChanged();
            }
        }
        public long TotalIncome
        {
            get { return _currentWallet.TotalIncome; }
        }
        public long TotalOutCome
        {
            get { return _currentWallet.TotalOutcome; }
        }
        #endregion

        

        #region Constructor
        public WalletConfigurationViewModel(WalletUIModel wallet)
        {
            _currentWallet = wallet;
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
