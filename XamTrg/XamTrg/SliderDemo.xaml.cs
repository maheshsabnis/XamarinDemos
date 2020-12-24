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
    public partial class SliderDemo : ContentPage
    {
        public SliderDemo()
        {
            InitializeComponent();

            // subscribing events using the Page object
            // slideValue.ValueChanged += SlideValue_ValueChanged;

            Label lbldisplay = new Label()
            { 
                Text = "My Runtime Label",
                FontSize = 50,
                TextColor = Color.Red,
                BackgroundColor = Color.FromRgb(40,60,255)
            };


            Label lblData = new Label()
            {
                Text = "Center Label",
                // reading the device where app will be deployed 
                // GetNamedSize() --> Access the Device Native Font
                // use the font for the Element 
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center, // how it will be placed in its container
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.FromRgb(50, 80, 255)
            };

            

            Slider slider = new Slider()
            {
                Minimum = 0, Maximum = 360
            };


            // subscribe to the event

            slider.ValueChanged += (sender, arguments) => {
                lblData.Rotation = slider.Value;

                // display the current angl;e of rotation
                lblData.Text = $"The Current Angle {arguments.NewValue}";
            };

            // runtime adding of elements
            stkPanel.Children.Add(lbldisplay);
            stkPanel.Children.Add(lblData);
            stkPanel.Children.Add(slider);


        }

        private void sliderDesign_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDesign.Rotation = sliderDesign.Value;
        }



        //private void SlideValue_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    lblShow.Text = slideValue.Value.ToString();
        //}
    }
}