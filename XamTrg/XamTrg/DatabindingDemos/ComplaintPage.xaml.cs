using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamTrg.Models;
namespace XamTrg.DatabindingDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComplaintPage : ContentPage, INotifyPropertyChanged
    {

        ComplaintsTypeList objCmplaints;

        
        public string[] ComplaintTypes { get; set; }

        public Complaints Complaints { get; set; }

        public ObservableCollection<Complaints> ComplaintsList { get; set; }


        public ComplaintPage()
        {
            InitializeComponent();
            objCmplaints = new ComplaintsTypeList();
            ComplaintTypes = objCmplaints.GetComplaintTypes();
            Complaints = new Complaints();
            ComplaintsList = new ObservableCollection<Complaints>();

            // bind all public properties of the current class
            // to the Page Elements
            BindingContext = this;
        }

        private void btnRegisterComplaint_Clicked(object sender, EventArgs e)
        {

            //DisplayAlert("Registered Complaint", $"{Complaints.ComplaintType} {Complaints.ComplaintDetails}",
            //    "Ok", "Cancel");
            // Add All Complaints in ObservableCollection
            ComplaintsList.Add(Complaints);
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            Complaints = new Complaints();

            BindingContext = this;
        }
    }
}