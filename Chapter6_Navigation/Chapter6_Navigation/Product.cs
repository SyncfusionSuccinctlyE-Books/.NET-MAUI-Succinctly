using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Navigation
{
    public class Product: INotifyPropertyChanged
    {
        private string _productName;
        private int _quantity;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));
        }
    }

    public class ProductCollection: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));
        }

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }
        public ProductCollection()
        {
            var product1 = new Product { ProductName = "Bread", Quantity = 10 };
            var product2 = new Product { ProductName = "Wearables", Quantity = 15 };
            var product3 = new Product { ProductName = "Wine", Quantity = 5 };
            var product4 = new Product { ProductName = "Tomatoes", Quantity = 100 };

            Products = new ObservableCollection<Product>() { product1, product2, product3, product4 };
        }
    }
}
