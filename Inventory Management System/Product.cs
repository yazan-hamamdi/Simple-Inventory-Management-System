using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{     
    internal class Product
    {
        private string _name;
        private double _price;
        private double _quantity;
        public Product( string name, double price, double quantity)
        {
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }
        private double check(double val) => val <= 0 ? 0 : val;
        public string name
        {
            set { this._name =value;}

            get{ return this._name;}
        }
        public double price
        {
            set { this._price =check(value); }

            get { return this._price; }
        }
        public double quantity
        {
            set { this._quantity = check(value); }

            get { return this._quantity; }
        }

        //*Add a product:* Prompt the user for the product name, price, and quantity, then add the product to the inventory
        public Product AddProduct(string name, double price, double quantity)
        {
          Product p=new Product(name, price, quantity);
            return p;
        }

        //*View all products:* Display a list of all products in the inventory
        public void DisplayProducts(List<Product>L)
        {
            foreach (var pro in L)
            {
                Console.WriteLine($"name is: {pro.name}");
                Console.WriteLine($"price is: {pro.price}");
                Console.WriteLine($"name is: {pro.quantity}");
                Console.WriteLine("+++++++++++++++++++++");
            }
        }
    }
}
