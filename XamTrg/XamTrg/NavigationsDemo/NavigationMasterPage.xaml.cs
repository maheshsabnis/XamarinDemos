using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamTrg.Models;

namespace XamTrg.NavigationsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationMasterPage : ContentPage
    {
        public NavigationMasterPage()
        {
            InitializeComponent();
        }

        private async void btnNavigateToDetails_Clicked(object sender, EventArgs e)
        {

            Employees emps = new Employees();
            var navigationDetailsPage = new NavigationDetailsPage();
            // settings the BindingContext for Details page 
            navigationDetailsPage.BindingContext = emps;

            //await Navigation.PushModalAsync(new NavigationDetailsPage());
            await Navigation.PushModalAsync(navigationDetailsPage);


        }
    }
}