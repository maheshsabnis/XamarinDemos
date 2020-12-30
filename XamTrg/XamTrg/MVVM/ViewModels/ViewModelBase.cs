using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamTrg.MVVM.ViewModels
{
    /// <summary>
    /// The abstract ViewModelBase acta as a base for all ViewModel classes
    /// This base class will implement INotifyPropertyChanged for change notifications for all
    /// ViewModel classes
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProprtyChanged(string pName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
            }
        }
    }
}
