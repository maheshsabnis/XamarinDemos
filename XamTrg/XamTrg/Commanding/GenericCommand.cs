using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XamTrg.Commanding
{
    public class GenericCommand : ICommand
    {
       public Action action { get; set; }
        
        


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            if (action != null)
            {
                return true;
            }
            return true;

        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
