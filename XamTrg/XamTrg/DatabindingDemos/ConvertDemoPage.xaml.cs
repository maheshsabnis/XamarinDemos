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
    public partial class ConvertDemoPage : ContentPage
    {
        public ConvertDemoPage()
        {
            InitializeComponent();
        }

        private void txtData_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtData.Text.Length > 0) btn.IsEnabled = true;
            else btn.IsEnabled = false;
        }
    }
}