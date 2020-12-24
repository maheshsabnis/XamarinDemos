using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamTrg.Models;

namespace XamTrg.DatabindingDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDataBinding : ContentPage
    {
        public ListViewDataBinding()
        {
            InitializeComponent();
           listViewProducts.BindingContext = new Products();
        }
    }
}