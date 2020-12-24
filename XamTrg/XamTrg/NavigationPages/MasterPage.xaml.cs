using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.NavigationPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private async void btnNavigate_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new DetailsPage());
            //var navDetailsPage = new NavigationPage(new DetailsPage());
            await Navigation.PushModalAsync(new DetailsPage());
          
        }
    }
}