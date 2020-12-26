using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.AddOnUIs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerUIPage : ContentPage
    {

        DateTime _timeTrigger;

        public DatePickerUIPage()
        {
            InitializeComponent();
            // Subscrice to the Device Time Settings to start the Click
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTick);
        }

        // The metgod that will be executed for device times
        private bool OnTick()
        {
            // display the Reminder if the Time is elapsed
            if (switchTimer.IsToggled && DateTime.Now >= _timeTrigger)
            {
                switchTimer.IsToggled = false;
                DisplayAlert("Reminder Aletr", entryReminder.Text, "OK");
            }

            return true;
        }


       
        private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           
                await DisplayAlert("Selected Date ", dtPicker.Date.ToString(), "Ok", "Cancel" );
            
        }


        /// <summary>
        /// The Logic for ,maiking sure that 
        /// the time change is detected for the device as the TimePicker changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // if the Time property is chenged for the Time Picker
            if (e.PropertyName == "Time")
            {
                SetReminderTime();
            }
        }

        private void switchTimer_Toggled(object sender, ToggledEventArgs e)
        {
            SetReminderTime();
        }


        /// <summary>
        /// This method will be called when the Switch Elem,ent is set to true
        /// </summary>

        void SetReminderTime()
        {
            // if the value for the toggle is true
            if (switchTimer.IsToggled)
            {
                // set the timer 
                // the times is by default set for Today's Time 
                // DateTime.Today  ToDay's Date
                // timePicker.Time: the set time for TimePicker
                _timeTrigger = DateTime.Today + timePicker.Time;

                // if the reminder is set for the next day e.g. AM or PM
                if (_timeTrigger < DateTime.Now)
                {
                    _timeTrigger += TimeSpan.FromDays(1);
                }
            }
        }
    }
}