using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.Commanding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandingPage : ContentPage
    {
       // DataProvider data;
        public CommandingPage()
        {
            InitializeComponent();
            // data = new DataProvider();
        }

        //private void btnMovies_Clicked(object sender, EventArgs e)
        //{
        //    lstmovies.ItemsSource = data.GetMovies();
        //}
    }
}