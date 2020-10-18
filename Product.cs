using System;
using System.Collections.Generic;
using System.Text;

namespace Frightos_Task
{

     public class Product
    {
        public String itemName { get; set; }
        public double itemPrice { get; set; }
        public int location { get; set; }//1-25
        public  int quantity { get; set; }
        public Product(String name, double price, int location)
        {
            this.itemName = name;
            this.itemPrice = price;
            this.location = location;
            this.quantity = 10;
        }
        public Product()
        {
        }
        public void updateQuantity()
        {
            quantity--;
        }

    }
}
