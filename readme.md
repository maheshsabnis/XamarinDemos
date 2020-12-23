# Creating the Slider and lable using Code and adding it on StackLayout on View
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


 
    }

#Creating Slider and Lable using XAML and Working with it
  <ContentPage.Content>
        <StackLayout x:Name="stkPanel">
            <!--<Label x:Name="lblShow" Text="Value = " TextColor="Yellow" BackgroundColor="Red"></Label>
            <Slider x:Name="slideValue" Minimum="0" Maximum="300"/>-->



            <StackLayout Margin="2,400, 2,2">

                <Slider x:Name="sliderDesign" Maximum="360" Minimum="0"
                         ValueChanged="sliderDesign_ValueChanged"></Slider>
                <Label Text="The Demo of Slider using Code"
                       FontSize="Large" x:Name="lblDesign"
                       HorizontalOptions="Center"
                       VerticalOptions="CenterAndExpand"
                       TextColor="Magenta"
                       BackgroundColor="Yellow"></Label>
                
            </StackLayout>
            
        </StackLayout>
    </ContentPage.Content>

# Creating a Color Picker
# The XAML
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamTrg.PickerPage">
    <ContentPage.Content>
        <StackLayout>
            <Label Text="Picker DEMO" x:Name="lblDisplay" FontSize="50"></Label>
            <Label Text="Please Select Color"></Label>
            <Picker x:Name="colorPicker"
                      SelectedIndexChanged="colorPicker_SelectedIndexChanged"></Picker>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>

#The C# COde with Converter
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