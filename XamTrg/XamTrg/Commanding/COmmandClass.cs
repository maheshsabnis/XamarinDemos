using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XamTrg.Commanding
{
    /// <summary>
    /// The Command class that will be used for handling the Action
    /// This command object should be aware of the class of ehich method will be
    /// executed and UI is updated
    /// </summary>
    public class ActionCommand : ICommand
    {
        DataProvider provider;
        public ActionCommand(DataProvider provider)
        {
            this.provider = provider;
        }

        /// <summary>
        /// This is the event that will be raised when the 
        /// CanExecute() method returns true.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Check for the condition to perform the Action Execution
        /// If this method returns true then execute else do not execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            bool action = false;
            if (provider.Movies.Count >= 0)
            {
                action = true;
            }
            return action;
        }

        /// <summary>
        /// The method responsible to execute the Action
        /// The method that contains logic to execute and update UI
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            provider.GetMovies();
        }
    }
}
