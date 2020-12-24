using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamTrg.restcalls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RESTPage : ContentPage
    {

        HttpClient client;
        public RESTPage()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("https://apiapptrainingnewapp.azurewebsites.net/api/Products");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                await DisplayAlert("The Response Data", content, "OK", "Cancel");
            }

        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            var product = new {
              ProductId="Prd4001", ProductName="My Product",
              CategoryName="ECT", Manufacturer="IBM", Description="Test",
              BasePrice=1000
            };
            string json = JsonConvert.SerializeObject(product);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
             
                response = await client.PostAsync("https://apiapptrainingnewapp.azurewebsites.net/api/Products", content);
            if (response.IsSuccessStatusCode)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                await DisplayAlert("The Response Data", content1, "OK", "Cancel");
            }
        }
    }
}