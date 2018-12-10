using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KMA.APZRPMJ2018.WalletSimulator.ViewModels;

namespace KMA.APZRPMJ2018.WalletSimulator.Views
{
    /// <summary>
    /// Логика взаимодействия для NoteConfigurationView.xaml
    /// </summary>
    public partial class NoteConfigurationView
    {
        public NoteConfigurationView(Models.Note note)
        {
            InitializeComponent();
            var walletModel = new NoteConfigurationViewModel(note);
            DataContext = walletModel;
        }

        private void NoteTextControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
}
