using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamTrg.Models;

namespace XamTrg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        Products products;

        public ListViewPage()
        {
         
            InitializeComponent();
            products = new Products();
           // listViewProducts.ItemsSource = products;
        }
    }
}