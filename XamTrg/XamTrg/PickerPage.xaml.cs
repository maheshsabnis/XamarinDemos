using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        List<string> colors;
        public PickerPage()
        {
            InitializeComponent();
            colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Black");
            colors.Add("Cyan");
            colors.Add("Magenta");
            colors.Add("Green");


            foreach (string col in colors)
            {
                colorPicker.Items.Add(col);
            } 


        }

        private void colorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Color Converter
            // Class used to convert the String into Color object
            var colorConverter = new ColorTypeConverter();

            Color c = (Color) colorConverter.ConvertFromInvariantString(colorPicker.SelectedItem.ToString());

            lblDisplay.TextColor = c;
        }
    }
}