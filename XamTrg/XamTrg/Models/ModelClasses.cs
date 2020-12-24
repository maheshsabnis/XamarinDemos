using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace XamTrg.Models
{
    public class Characters
    {
        private string[] Actors = new string[] { "Sean Connary", "George Luznaby", "Roger Moore", 
            "Trimothy Dalton", "Pierce Brosnon", "Daniel Craig" };

        public string[] GetActors()
        {
            return Actors; 
        }
    }



    public class Product
    {
        
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public int BasePrice { get; set; }

    }


    public class Products : ObservableCollection<Product>
    {
        public Products()
        {
            Add(new Product() {ProductId="Prd001", ProductName="Laptop", Manufacturer="HP",BasePrice=120000 });
            Add(new Product() { ProductId = "Prd002", ProductName = "Router", Manufacturer = "HP", BasePrice = 1200 });
            Add(new Product() { ProductId = "Prd003", ProductName = "Desktop", Manufacturer = "IBM", BasePrice = 40000 });
            Add(new Product() { ProductId = "Prd004", ProductName = "Hard Disk", Manufacturer = "HP", BasePrice = 1000 });
            Add(new Product() { ProductId = "Prd005", ProductName = "RAM", Manufacturer = "IBM", BasePrice = 12000 });
            Add(new Product() { ProductId = "Prd006", ProductName = "Processor", Manufacturer = "IBM", BasePrice = 20000 });
        }
    }




    public class ComplaintsTypeList
    {
        private string[] complaintTypes = new string[]
        { 
           "Internet is not Working",
           "Router is not showing power",
           "Cable is broaken",
           "Speed is slow",
           "Internet browing problem",
           "Router is nopty showing connection lights"
        };

        public string[] GetComplaintTypes()
        {
            return complaintTypes;
        }
    }


    /// <summary>
    /// The Class implement the  INotifyPropertyChanged interface
    /// This will be used to notify to the UI that the property is been modified
    /// and the corresponding UI can be updated
    /// </summary>

    public class Complaints : INotifyPropertyChanged
    {
        string complaintType;
        string complaintDetails;

        public string ComplaintType
        {
            get {
                return complaintType;
            }
            set {
                complaintType = value;
                OnPropertyChanged("ComplaintType");
            }
        }

        public string ComplaintDetails
        {
            get
            {
                return complaintDetails;
            }
            set
            {
                complaintDetails = value;
                OnPropertyChanged("ComplaintDetails");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
                // the current object will raise the event and 
                // pass the property name that is updated / changed
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
        }
    }

}
