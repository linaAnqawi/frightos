using System;
using System.Collections.Generic;
using System.Text;

namespace Frightos_Task
{
    abstract class VendingMachine
    {
        List<Product> iteams = new List<Product>();

        public VendingMachine()
        {
        }
        public VendingMachine(List<Product> iteams)
        {
            Initialization(iteams);
        }
        //apstract method 
        public abstract void Initialization(List<Product> iteams);
    }

}
  
