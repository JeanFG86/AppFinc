using AppFinc.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppFinc.ViewModels
{
    public class TransactionListViewModel : ObservableObject
    {
        public ICommand ButtonClickCommand { get; private set; }

        public TransactionListViewModel()
        {
            ButtonClickCommand = new RelayCommand(CallPage);
        }

        private void CallPage()
        {
            App.Current.MainPage = new TransactionAdd();
        }
        
    }
}
