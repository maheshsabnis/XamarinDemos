using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.DatabindingDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementToElementBinding : ContentPage
    {
        public ElementToElementBinding()
        {
            InitializeComponent();
        }
    }
}