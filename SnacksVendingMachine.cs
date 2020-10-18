using System;
using System.Collections.Generic;
using System.Text;

namespace Frightos_Task
{
    //inheritance
    class SnacksVendingMachine : VendingMachine
    {
        // quantity of coins 
        //CoinSlot: There are four denominations: • 10c • 20c • 50c • $1 
        public static int quantityOfTenCoin = 10;
        public static int quantityOfTwentyCoin = 10;
        public static int quantityOfFiftyCoin = 10;
        public static int quantityOfOneDolar = 10;
        //Notes Slot :20$ and 50$ only
        public static int quantityOfTwentyNotes = 10;
        public static int quantityOfFiftyNotes = 10;
        public SnacksVendingMachine(List<Product> iteams) : base(iteams)
        {
            Initialization(iteams);
        }

        public override void Initialization(List<Product> iteams)
        {
            iteams.Add(new Product("Smucker's", 2.3, 1));
            iteams.Add(new Product("Cheez-It", 1, 2));
            iteams.Add(new Product("Cheetos", 3.2, 3));
            iteams.Add(new Product("Tostitos", 2, 4));
            iteams.Add(new Product("Nabisco", 3, 5));
            iteams.Add(new Product("Jif", 3.3, 6));
            iteams.Add(new Product("Fritos", 9, 7));
            iteams.Add(new Product("Cheerios",1, 8));
            iteams.Add(new Product("Campbell's", 6, 9));
            iteams.Add(new Product("Doritos", 7.5, 10));
            iteams.Add(new Product("Betty Crocker", 9, 11));
            iteams.Add(new Product("Dove", 2, 12));
            iteams.Add(new Product("Nestlé Toll House", 3, 13));
            iteams.Add(new Product("Kellogg's", 4, 14));
            iteams.Add(new Product("Pillsbury", 7.7, 15));
            iteams.Add(new Product("Frito-Lay", 8, 16));
            iteams.Add(new Product("Planters", 8.9, 17));
            iteams.Add(new Product("Oreo Cookies", 3, 18));
            iteams.Add(new Product("Lay's Chips", 11, 19));
            iteams.Add(new Product("Kit Kat", 9, 20));
            iteams.Add(new Product("Ritz", 5, 21));
            iteams.Add(new Product("Quaker", 3, 22));
            iteams.Add(new Product("Reese's",4, 23));
            iteams.Add(new Product("Hershey's", 3, 24));
            iteams.Add(new Product("M&M's", 2, 25));
       }      
    }
}
