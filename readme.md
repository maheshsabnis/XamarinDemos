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


# Showing the Message Box using DiaplyAlert
 private void pickerActor_SelectedIndexChanged(object sender, EventArgs e)
        {
             DisplayAlert("Selected Actor", pickerActor.SelectedItem.ToString(), "Select", "Cancel");
        }
 

# Set Values
Used to Pick or select values from elements
1. Slider
2. Switch
3. DatePicker
4. TimePicker
5. CheckBox

They contains predefined values and we can select values from it

# Data Entry Elements
1. Editor
2. Entry


# Xamarin Collection Elements used for Data-Binding Operations
USe the Collection Elements for Line-of-Business (LOB) Appss

The ObservableCollection Class
- This is the class used as Data Source to Collection Elements
- USed to display Data in Tabular form
- This class implements INotifyCollectionChanged, INotifyPropertyChanged interfaces
    - INotifyPropertyChanged, interface contains 'PropertyChanged' event that is raised when any property in 
        collection is updated
    INotifyCollectionChanged, interface contains 'CollectionChanged' event that is raised when any record in 
        collection is changed
- Any updated in the UI updates the collection
- Any updates in Collection Updates UI



1. Picker
2. ListView
    - Use this in Xamarin for displayind collection of Data in scroaable manner. 
    - You can customize the data diaplsy in List View
    - The collection accepted by the ListView and other Collection Elemnets* is 'ObservableCollection' 
    - To Customize the Data in the ListView define 'ItemTemplate'
        - ItemTemplate is a mechanism of customizing the Element Display in the ListView 
ListView with the Hard-Coded Data
 
 <ListView x:Name="listViewProducts">
                <ListView.ItemsSource>
                    <!--Displaying the String Data-->
                    <x:Array Type="{x:Type x:String}">
                        <x:String>Mahesh</x:String>
                        <x:String>Tejas</x:String>
                        <x:String>Ramesh</x:String>
                        <x:String>Ram</x:String>
                    </x:Array>
                </ListView.ItemsSource>
            </ListView>



3. TableView
4. CollectionView
5. CarouselView
Common proprties like Items, ItemsSource


#Databinding
1. Process of building the Xamarin apps with less code in Code-behind by directly loading the model objects 
    in XAML Design
2. Reduces the Boiler-Plate code for creating an instance of the Model class in Xaml Code behind (.xaml.cs) and 
    showing data in XAML Elements
3. Promotes the Code-Less development
4. Result in creating Model-View-ViewModel (MVVM) based apps

The 'Binding' class in the Xamarin.Forms namespace

Properties of Binding Class
1. Mode
    - Default
        - Read data from source and bind with the Element
    - OneWay
        - Data goes from source to target
    - TwoWay
        - data goes both ways between source and target
    - OneWayTowSource
        - data goes from target to source
    - OneTime
        - data goes from sourcve to target, but only when the 'BindingContext' changes (Xamarin.Forms 3.0+) 
    - Source is the Data Provider
        - Other XAML Element and its 'BindableProperty'
            - BindableProperty means the property that is used to Read /Write the value from and to XAML element
            - This proeprty is used to manage the display of XAML element
                - e.g. TextColor, Text, BackgoundColor, SelectecItem, ItesmSource, Item, HeightRequest, WidthRequest
            - One XAML element can be bound with other XAML element (Code-less development)
        - Model Objects aka CLR objects
            - Classes with public properties
            - Collections
    - Target is the Data Consumer that shows data and update database on Event
        - XAML element that shows data and update the data based on Events 
2. Path
    - the Property from the source that emits value so that the value is shown on target
3. Source
    - The Source object from which the value is read
4. Converter
    - COnverts the value for Binding
    - The property is of the type IValueConverter interface with following two methods
        - Convert(), accept following paramatere
            - object --> Value to convert
            - Type --> The terget type for the vconvertion
            - CultureInfo --> The type of culture to convert    
       - ConvertBack
            - Convert to original value

5. FallbackValue
    - If source failes to pass the data to target then instead of showing blank value create fallback value 
        e.g. Not Available for string datatype and 0 for numeric
6. TargetNullValue
    - If the Source has null value then crrate a placeholder
7. StringFormat
    - Format the data display in binding e.g. Decimal points, Date Formats, time formats etc.
    
    

Syntax
    {Binding Source={x:Reference Name=<NAME-OF-SOURCE-ELEMENT>}, Path=<VALUE-OF-BINDABABLE-PROPERTY-OF-SOURCE>,
      Convert={<TYPE-NAME-OF-CONVERTER-LOGIC (aka CONVERTER-CLASS)>}, FallbackValue={}, TargetNullVBalue={}, 
       StringFormat=""}

# Eleemnt-To-Element Binding
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamTrg.DatabindingDemos.ElementToElementBinding">
    <ContentPage.Content>
        <StackLayout>
            <!--Picke has selected Item-->
            <Label Text="Element To Element Binding"
                    FontSize="{Binding Source={x:Reference sliderFontSize}, Path=Value}"
                    HorizontalOptions="Center"
                    VerticalOptions="CenterAndExpand" 
                    TextColor="{Binding Source={x:Reference colorPicker}, Path=SelectedItem}"
                    BackgroundColor="Yellow"
                    Rotation="{Binding Source={x:Reference sliderSource}, Path=Value}"></Label>

            <!--The Slider's ValueChanged Event is emitteing the 'Value'
              this value will be used by the Lable element-->
            
            <Slider x:Name="sliderSource"
                     Maximum="360"
                     VerticalOptions="CenterAndExpand"></Slider>

            <Slider x:Name="sliderFontSize"
                     Maximum="100" Minimum="4" Value="10"
                     VerticalOptions="CenterAndExpand"></Slider>
            <Picker x:Name="colorPicker">
                <Picker.Items>
                    <x:String>Red</x:String>
                    <x:String>Magenta</x:String>
                    <x:String>Green</x:String>
                    <x:String>Black</x:String>
                </Picker.Items>
            </Picker>

        </StackLayout>
    </ContentPage.Content>
</ContentPage>



# The Model Class

    public class Employee : INotifyPropertyChanged
    {

        int _EmpNo;
        public int EmpNo
        {
            get { return _EmpNo; }
            set
            {
                _EmpNo = value;
                OnPropertyChanged("EmpNo");
            }
        }
        string _EmpName;
        public string EmpName
        {
            get { return _EmpName; }
            set
            {
                _EmpName = value;
                OnPropertyChanged("EmpName");
            }
        }
        int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set
            {
                _Salary = value;
                OnPropertyChanged("Salary");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
            }
        }
    }



    public class Employees : ObservableCollection<Employee>
    {
        public Employees()
        {
            Add(new Employee() {EmpNo=101,EmpName="Mahesh",Salary=1000 });
            Add(new Employee() { EmpNo = 102, EmpName = "Ramesh", Salary = 2000 });
            Add(new Employee() { EmpNo = 103, EmpName = "Tejas", Salary = 1200 });



        }
    }

#COde Less Xaml for declaring an instance of CLR nobject in XAML
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamTrg.DatabindingDemos.CodeLessListView"
             xmlns:src="clr-namespace:XamTrg.Models">

    <!-- xmlns:src="clr-namespace:XamTrg.Models": Registering the Namespace-->

    
    <!--Resources is the Resource Dicatoinary of
      Page, Layout Elements to define the instances for
      CLR objects or Styles-->
    <ContentPage.Resources>
        <!--x:Key is the instance of the Employees class-->
        <src:Employees x:Key="empds"></src:Employees>
    </ContentPage.Resources
    >
    
    <ContentPage.Content>
        <StackLayout>
             
            <Label Text="CodeLess ListView" FontSize="40" FontFamily="Times New Roman"></Label>
            <!--BindingContext="{Binding Source={x:StaticResource empds} }" means that set the Context for the databoinding 
            to an instance of Employees class
              ItemsSource="{Binding}"  empty binding means that use the binding source 
            of 'BindingContext' of element itself
             or use 'BindingContext' of its parent
          
            -->
            <ListView BindingContext="{Binding Source={x:StaticResource empds} }" 
                      ItemsSource="{Binding}">
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <StackLayout Orientation="Horizontal">
                                <Label Text="{Binding Path=EmpNo}"></Label>
                                <Label Text="{Binding Path=EmpName}"></Label>
                                <Label Text="{Binding Path=Salary}"></Label>
                            </StackLayout>
                        </ViewCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>


# Converter Implementation
 public class EnableDisableBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // if the length of data in Entry is not 0 then return true else false
            if ((int)value != 0) return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }




# Permission to access REST Calls
 <uses-permission android:name="android.permission.INTERNET" /> 
 <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
 <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" /> 
 <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
 <uses-permission android:name="android.permission.CHANGE_NETWORK_STATE" />
 <uses-permission android:name="android.permission.CHANGE_WIFI_STATE"/>

