using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DatabindingDemos.ComplaintPage();
        }

        /// <summary>
        /// When App Strats
        /// </summary>
        protected override void OnStart()
        {
        }
        /// <summary>
        /// When App is Send Behind other app in Stack 
        /// </summary>

        protected override void OnSleep()
        {
        }

        /// <summary>
        /// When the App is again brought forward
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}
