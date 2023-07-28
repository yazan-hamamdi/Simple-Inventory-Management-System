using System;

namespace Inventory_Management_System 
{
    internal class Inventory
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product p= new Product("yazan",12,1);
            int button = 0;
            bool flag = true;
            Console.WriteLine("This program will not stop until you choose Close :) ");
            while (flag)
            {
                Console.WriteLine("Now choose the action you want ");
                Console.WriteLine("1. add product \n 2.display products \n 3.Edit product \n 4.Delete product \n 5.Search a product \n 6. Close ");
                button =Convert.ToInt32(Console.ReadLine());
                  if (button == 1) 
                  {
                    Console.Write($"name is: ");
                   var name= Console.ReadLine();
                    Console.Write($"price is: ");
                    var price = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"quantity is: ");
                    var quantity = Convert.ToDouble(Console.ReadLine());
                    products.Add( Product.AddProduct(name,price,quantity) );
                }
                  else if( button == 2)
                {
                    Product.DisplayProducts( products );
                }
                  else if( button == 3)
                {
                    Console.Write(" enter name the product to edit it: ");
                    var name = Console.ReadLine();
                    Product.EditProducts(products, name);
                }

                else if( button == 4)
                {
                    Console.Write(" enter name the product to edit it: ");
                    var name = Console.ReadLine();
                    Product.DeleteProducts(products, name);
                }

                else if (button == 5)
                {
                    Console.Write(" enter name the product to edit it: ");
                    var name = Console.ReadLine();
                    Product.SearchProducts(products, name);
                }

                else if (button == 6)
                {
                    flag = false;
                }

            }
        }
    }
}
