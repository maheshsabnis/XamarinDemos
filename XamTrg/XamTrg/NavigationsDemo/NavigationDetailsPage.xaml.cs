using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.NavigationsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationDetailsPage : ContentPage
    {
        public NavigationDetailsPage()
        {
            InitializeComponent();
        }

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            // remove the self page frrom the Navigation Stack and 
            // moveto the page from where the navigation has taken Place to this page
            await Navigation.PopModalAsync();
        }
    }
}