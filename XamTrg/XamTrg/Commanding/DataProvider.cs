using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace XamTrg.Commanding
{
    /// <summary>
    /// Since this class is responsible for providing data to UI
    /// with code-less approach, create a command property in the class
    /// of the type Custom Command object of name ActionCommand
    /// and in the action command call the methood from the DataProvider
    /// class to fill the collection
    /// </summary>
    public class DataProvider
    {
        ActionCommand actionCommand;

        GenericCommand GenericCommand { get; set; }

        ObservableCollection<string> movies;



        public DataProvider()
        {
            movies = new ObservableCollection<string>();
            GenericCommand = new GenericCommand()
            { 
                 action =  GetMoviesGeneric
            };

        }

        /// <summary>
        /// The entire class instance is passed to Command Property hence to command object
        /// This property will be bound to the command property of the Button
        /// </summary>
        public ICommand GetCommand
        {
            get
            {
                return new ActionCommand(this);   
            }
        }




        /// <summary>
        /// declaring the public property for databinding
        /// </summary>
        public ObservableCollection<string> Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        /// <summary>
        /// The method responsible for updating the Property
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<string> GetMovies()
        {
            Movies.Add("Dr.No");
            Movies.Add("From Russia With Love");
            Movies.Add("Moonrekar");
            Movies.Add("Goldenc Eye");
            
            return Movies;
        }
        private void GetMoviesGeneric()
        {
            Movies.Add("Dr.No");
            Movies.Add("From Russia With Love");
            Movies.Add("Moonrekar");
            Movies.Add("Goldenc Eye");
      
        }
    }
}
