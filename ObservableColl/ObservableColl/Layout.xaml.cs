using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ObservableColl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layout : ContentPage
    {
        public Layout()
        {
            InitializeComponent();
            listView.ItemsSource = Data.ProductList;
        }

        public object DisableSelectionHighlighting { get; private set; }
        public object SelectedItem { get; private set; }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var selection = e.SelectedItem as Product;
                DisplayAlert("You selected", selection.Name, "OK");


            }
        }

        void OnFavorite(object sender, EventArgs e)
        {
            var selectedItem = (MenuItem)sender;
            var selectedProduct = selectedItem.CommandParameter as Product;
            DisplayAlert("Favorite", $"You added item {selectedProduct.Name} to favorites", "OK");
        }
    }
}