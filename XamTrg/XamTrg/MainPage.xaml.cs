using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamTrg
{
    public partial class MainPage : ContentPage
    {
        List<string> professions;
        public MainPage()
        {
            InitializeComponent();
            // all initializations in constructor must be done after the the
            // INitializeComponent() method

            professions = new List<string>();
            professions.Add("Doctor");
            professions.Add("Enginerr");
            professions.Add("Architect");
            professions.Add("Trainer");
            professions.Add("Pilot");

            foreach (var item in professions)
            {
                lstprofession.Items.Add(item);
            }
        }

        void btnClear_Clicked(System.Object sender, System.EventArgs e)
        {
            firstName.Text = "";
            middleName.Text = "";
            lastName.Text = "";
        }

        void btnSave_Clicked(System.Object sender, System.EventArgs e)
        {
            lblInfo.Text = $"The Data Recived {firstName.Text} {middleName.Text} {lastName.Text} {lstprofession.SelectedItem.ToString()} ";
        }
    }
}
