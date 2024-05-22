using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Navigation
{
    public class ItemsSearchHandler : SearchHandler
    {
        public ObservableCollection<Product> Products { get; set; }

        public ItemsSearchHandler()
        {
            Products = new ProductCollection().Products;
            ItemsSource = Products;
        }

        protected override void OnQueryChanged(string oldValue,
                  string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (!string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = Products.Where(p => p.ProductName
                .ToLower().Contains(newValue.ToLower()))
                .ToList();
            }

        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await (App.Current.MainPage as Shell).
                   GoToAsync($"ObjectDetails?name={((Product)item).ProductName}");
        }
    }
}
