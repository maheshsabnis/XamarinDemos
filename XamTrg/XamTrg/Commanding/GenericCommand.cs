using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XamTrg.Commanding
{
    public class GenericCommand : ICommand
    {
        Action action;

        public GenericCommand(Action handler)
        {
            action = handler;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            bool op = false;
            if (action != null)
            {
                op = true;
            }
            return op;

        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
