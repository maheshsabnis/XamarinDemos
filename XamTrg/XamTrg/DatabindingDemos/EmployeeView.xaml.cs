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
    public partial class EmployeeView : ContentPage
    {

        private Employee _Employee;
        ObservableCollection<Employee> collection;

        public EmployeeView()
        {
            InitializeComponent();
            Employee  =new Employee();
            collection = new ObservableCollection<Employee>();

            // please detech changed in publuc properties 
            // of the current class and Update the property values
            // and update the UI
            BindingContext = this;
        }


        public Employee  Employee
        {
            get { return _Employee; }

            set
            {
                _Employee = value;
                
            }
        }



        private void btnClear_Clicked(object sender, EventArgs e)
        {
            txteno.Text = "";
            txtename.Text = "";
            txtsal.Text = "";
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            //ObservableCollection<object> collection = new ObservableCollection<object>();
            //// creating Anonymous type
            //var empObject = new {EmpNo=txteno.Text, EmpName = txtename.Text, Salary=txtsal.Text };
            //collection.Add(empObject);

             
            collection.Add(Employee);
            listViewEmployee.BindingContext = collection;
            listViewEmployee.ItemsSource = collection;
        }

        
    }
}