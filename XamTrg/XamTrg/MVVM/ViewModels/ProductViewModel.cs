using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamTrg.MVVM.Models;
using XamTrg.MVVM.Services;

namespace XamTrg.MVVM.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        /// <summary>
        /// Private declarations
        /// </summary>
        private ProductInfo _Product;
        private ObservableCollection<ProductInfo> _Products;
        private ProductService productService;


        public ProductViewModel()
        {

            #region Instantiate public properties and service objects
            Product = new ProductInfo();
            Products = new ObservableCollection<ProductInfo>();
            productService = new ProductService();
            #endregion


            #region Configure Command Properties by passing private method references to it
            GetProductsCommand = new Command(GetData);
            AddProductCommand = new Command(AddProduct);
            #endregion

        }

        #region Command Properties
        public ICommand GetProductsCommand { get; private set; }
        public ICommand AddProductCommand { get; private set; }
        #endregion


        #region Public Propertie for Private declarations 
        public ProductInfo Product
        {
            get 
            {
                return _Product;
            }
            set
            {
                _Product = value;
                OnProprtyChanged("Product");
            }
        }

        public ObservableCollection<ProductInfo> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                _Products = value;
                OnProprtyChanged("Products");
            }
        }


        #endregion


        #region Private one-way methods. These method will call to Services for Read/Write operations
        private async void GetData()
        {
            var productsResponse = await productService.GetProductInfoDataAsync();
            foreach (ProductInfo prd in productsResponse)
            {
                _Products.Add(prd); // call CollectionChanged and then PropertyChanged on ObservableCollection
            }
        }

        private async void AddProduct()
        {
            Product = await productService.PostProductInfoAsync(Product);
        }
        #endregion

    }
}
