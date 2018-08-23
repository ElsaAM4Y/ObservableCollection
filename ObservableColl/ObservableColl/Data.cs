using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ObservableColl
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitCost { get; set; }
        public string ImageName { get; set; }
    }

    public class Data
    {
        #region ProductList
        public static ObservableCollection<Product> ProductList = new ObservableCollection<Product>
        {
            new Product{ID= 1, Name="Cloud Storage", UnitCost= 19.99m, ImageName= "Alfabet.jpg"},
            new Product{ID= 2, Name="DesktopComputer", UnitCost= 499.99m, ImageName="Auto.jpg"},
            new Product{ID= 3, Name="Disk Storage", UnitCost= 39.99m, ImageName= "blauw.jpg"},
            new Product{ID= 4, Name="Monitor", UnitCost= 199.99m, ImageName= "Euh.jpg"},
            new Product{ID= 5, Name="Security", UnitCost= 29.99m, ImageName= "Rekensom.jpg"},
            new Product{ID= 6, Name="Smartphone", UnitCost= 599.99m, ImageName= "Stilte.png"},
        };
        #endregion
    }
}
