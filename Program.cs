using System;
using System.Collections.Generic;

namespace Frightos_Task
{
    class Program
    {
        //main class
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            double totalprice = 0;
            int payoption = 0;
            double custoMermoney = 0;
            List<Product> iteam = new List<Product>();
            SnacksVendingMachine snacks = new SnacksVendingMachine(iteam);
            Console.Clear();
            Console.WriteLine("which type of Snacks would like to eat ?");
            Console.WriteLine("\n\n");
            for (int i = 0; i <= 24; i=i+5)
            {
                Console.WriteLine("(" + iteam[i].location + ") "+ iteam[i].itemName + " | "+"(" + iteam[i+1].location + ") " + iteam[i+1].itemName + " | " + "(" + iteam[i + 2].location + ") " + iteam[i + 2].itemName + " | " + "(" + iteam[i + 3].location + ") " + iteam[i + 3].itemName + " | " + "(" + iteam[i + 4].location + ") " + iteam[i + 4].itemName+"\r\n\n");
            }
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    DisplayResult(iteam[0].itemName+"");
                    if (iteam[0].quantity > 0)
                    {
                        iteam[0].updateQuantity();
                        totalprice = iteam[0].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if(payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }    
                        Console.Write("the rest of money is");
                        double rest =RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest+"\r\n");
                        int numberOfTwentyCoines=0;
                        int numberOfFiftyCoines=0;
                        int numberOftenCoines=0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                               numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                               numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                         z= rest/50;
                         x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {
                            
                            for (int i=0;i<x;i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x!=0)
                        {
                           
                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin --;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {
                            
                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: "+numberOfFiftyNote+",20$: "+numberOfTwentyNote+",$1: "+numberOfOneDolers+",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {
                           
                                Console.Write("we take " + totalprice + " from youre banks account ");
                            
                        }
                    }
                   
                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "2":
                    DisplayResult(iteam[1].itemName + "");
                    if (iteam[1].quantity > 0)
                    {
                        iteam[1].updateQuantity();
                        totalprice = iteam[1].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "3":
                    DisplayResult(iteam[2].itemName + "");
                    if (iteam[2].quantity > 0)
                    {
                        iteam[2].updateQuantity();
                        totalprice = iteam[2].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "4":
                    DisplayResult(iteam[3].itemName + "");
                    if (iteam[3].quantity > 0)
                    {
                        iteam[3].updateQuantity();
                        totalprice = iteam[3].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "5":
                    DisplayResult(iteam[4].itemName + "");
                    if (iteam[4].quantity > 0)
                    {
                        iteam[4].updateQuantity();
                        totalprice = iteam[4].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "6":
                    DisplayResult(iteam[5].itemName + "");
                    if (iteam[5].quantity > 0)
                    {
                        iteam[5].updateQuantity();
                        totalprice = iteam[5].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "7":
                    DisplayResult(iteam[6].itemName + "");
                    if (iteam[6].quantity > 0)
                    {
                        iteam[6].updateQuantity();
                        totalprice = iteam[6].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "8":
                    DisplayResult(iteam[7].itemName + "");
                    if (iteam[7].quantity > 0)
                    {
                        iteam[7].updateQuantity();
                        totalprice = iteam[7].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "9":
                    DisplayResult(iteam[8].itemName + "");
                    if (iteam[8].quantity > 0)
                    {
                        iteam[8].updateQuantity();
                        totalprice = iteam[8].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "10":
                    DisplayResult(iteam[9].itemName + "");
                    if (iteam[9].quantity > 0)
                    {
                        iteam[9].updateQuantity();
                        totalprice = iteam[9].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "11":
                    DisplayResult(iteam[10].itemName + "");
                    if (iteam[10].quantity > 0)
                    {
                        iteam[10].updateQuantity();
                        totalprice = iteam[10].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "12":
                    DisplayResult(iteam[11].itemName + "");
                    if (iteam[11].quantity > 0)
                    {
                        iteam[11].updateQuantity();
                        totalprice = iteam[11].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "13":
                    DisplayResult(iteam[12].itemName + "");
                    if (iteam[12].quantity > 0)
                    {
                        iteam[12].updateQuantity();
                        totalprice = iteam[12].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "14":
                    DisplayResult(iteam[13].itemName + "");
                    if (iteam[13].quantity > 0)
                    {
                        iteam[13].updateQuantity();
                        totalprice = iteam[13].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "15":
                    DisplayResult(iteam[14].itemName + "");
                    if (iteam[14].quantity > 0)
                    {
                        iteam[14].updateQuantity();
                        totalprice = iteam[14].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "16":
                    DisplayResult(iteam[15].itemName + "");
                    if (iteam[15].quantity > 0)
                    {
                        iteam[15].updateQuantity();
                        totalprice = iteam[15].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "17":
                    DisplayResult(iteam[16].itemName + "");
                    if (iteam[16].quantity > 0)
                    {
                        iteam[16].updateQuantity();
                        totalprice = iteam[16].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "18":
                    DisplayResult(iteam[17].itemName + "");
                    if (iteam[17].quantity > 0)
                    {
                        iteam[17].updateQuantity();
                        totalprice = iteam[17].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "19":
                    DisplayResult(iteam[18].itemName + "");
                    if (iteam[18].quantity > 0)
                    {
                        iteam[18].updateQuantity();
                        totalprice = iteam[18].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "20":
                    DisplayResult(iteam[19].itemName + "");
                    if (iteam[19].quantity > 0)
                    {
                        iteam[19].updateQuantity();
                        totalprice = iteam[19].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "21":
                    DisplayResult(iteam[20].itemName + "");
                    if (iteam[20].quantity > 0)
                    {
                        iteam[20].updateQuantity();
                        totalprice = iteam[20].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "22":
                    DisplayResult(iteam[21].itemName + "");
                    if (iteam[21].quantity > 0)
                    {
                        iteam[21].updateQuantity();
                        totalprice = iteam[21].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "23":
                    DisplayResult(iteam[22].itemName + "");
                    if (iteam[22].quantity > 0)
                    {
                        iteam[22].updateQuantity();
                        totalprice = iteam[22].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "24":
                    DisplayResult(iteam[23].itemName + "");
                    if (iteam[23].quantity > 0)
                    {
                        iteam[23].updateQuantity();
                        totalprice = iteam[23].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "25":
                    DisplayResult(iteam[24].itemName + "");
                    if (iteam[24].quantity > 0)
                    {
                        iteam[24].updateQuantity();
                        totalprice = iteam[24].itemPrice;
                        DisplaytotalPrice(totalprice + "$");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();

                        }
                        else if (payoption == 2)
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();
                        }
                        Console.Write("the rest of money is");
                        double rest = RestOfMoney(totalprice, custoMermoney);
                        Console.Write(rest + "\r\n");
                        int numberOfTwentyCoines = 0;
                        int numberOfFiftyCoines = 0;
                        int numberOftenCoines = 0;
                        int numberOfOneDolers = 0;
                        int numberOfFiftyNote = 0;
                        int numberOfTwentyNote = 0;
                        double z = rest / 500000;
                        int x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyNotes--;
                                numberOfFiftyNote++;
                            }
                            rest = rest - (x * 5000);
                        }
                        z = rest / 200000;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyNotes--;
                                numberOfTwentyNote++;
                            }
                            rest = rest - (x * 2000);
                        }
                        z = rest / 100;
                        x = (int)z;

                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfOneDolar--;
                                numberOfOneDolers++;
                            }
                            rest = rest - (x * 100);
                        }

                        z = rest / 50;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfFiftyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfFiftyCoin--;
                                numberOfFiftyCoines++;
                            }
                            rest = rest - (x * 50);
                        }
                        z = rest / 20;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTwentyCoin--;
                                numberOfTwentyCoines++;
                            }
                            rest = rest - (x * 20);
                        }
                        z = rest / 10;
                        x = (int)z;
                        if (x < SnacksVendingMachine.quantityOfTwentyCoin & x != 0)
                        {

                            for (int i = 0; i < x; i++)
                            {
                                SnacksVendingMachine.quantityOfTenCoin--;
                                numberOftenCoines++;
                            }
                            rest = rest - (x * 10);
                        }
                        Console.WriteLine("50$: " + numberOfFiftyNote + ",20$: " + numberOfTwentyNote + ",$1: " + numberOfOneDolers + ",50c:" + numberOfFiftyCoines + ", 20c:" + numberOfTwentyCoines + ", 10c:" + numberOftenCoines);

                        if (payoption == 3)
                        {

                            Console.Write("we take " + totalprice + " from youre banks account ");

                        }
                    }

                    else
                    {
                        Console.WriteLine("This type of snack is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                default:

                    return true;
            }
           
        }
    

        private static void DisplayResult(string message)
        {
            Console.Clear();
            Console.WriteLine($"\r\nyour option is: {message}");
       
        }
        
        
        private static void DisplaytotalPrice(string message)
        {
            
            Console.WriteLine($"\r\n the total price of your order is: {message}");
            Console.Write("\r\n would you like to conform this order ");
            Console.WriteLine("enter yes if you want");
            string x=Console.ReadLine();

        }

        private static int paymnue()
        {
            Console.Clear();
            Console.WriteLine(" would you like to pay by Coins or by notes");
            Console.WriteLine("1) Coin");
            Console.WriteLine("2) Notes");
            Console.WriteLine("3) Cards");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayResult("your option was coin");
                    return 1;
                case "2":
                    DisplayResult("your option was notes");
                    return 2;
                
                default:
                    DisplayResult("your option was cards");
                    return 3;
            }
        }
        private static void coinmnue()
        {
            Console.Clear();
            Console.WriteLine(" the machine just accept these value of coin");
            Console.WriteLine("1) 10 c");
            Console.WriteLine("2) 20 c");
            Console.WriteLine("3) 50 c");
            Console.WriteLine("4) 1 $");
            Console.WriteLine("are you sure tou want to payed by coins");
            string x = Console.ReadLine();
            if (!x.Equals("yes"))
            {
                paymnue();

            }
        }
        private static void notesmnue()
        {
            Console.Clear();
            Console.WriteLine(" the machine just accept these value of notes");
            Console.WriteLine("1) 20 nis");
            Console.WriteLine("2) 50 nis");
            Console.WriteLine("are you sure tou want to payed by coins");
            string x = Console.ReadLine();
            if (!x.Equals("yes"))
            {
                paymnue();

            }

        }

        private static double TakeCoin()
        {
            string input = "";
            int coin20 = 0;
            int coin50 = 0;
            int coin10 = 0;
            int coin1 = 0;
            double totalprice = 0;
             Console.Clear();
             Console.WriteLine($"\r\n please insert the (1 $) coins :");
             Console.Write("\r\n: ");
             input = Console.ReadLine();
             coin1=int.Parse(input)*100;
            SnacksVendingMachine.quantityOfOneDolar++;
             Console.WriteLine($"\r\n please insert the (10 c) coins :");
             Console.Write("\r\n: ");
             input = Console.ReadLine();
             coin10 = int.Parse(input)*10;
            SnacksVendingMachine.quantityOfTenCoin++;
             Console.WriteLine($"\r\n please insert the (20 c) coins :");
             Console.Write("\r\n : ");
             input = Console.ReadLine();
             coin20 = int.Parse(input)*20;
            SnacksVendingMachine.quantityOfTwentyCoin++;
            Console.WriteLine($"\r\n please insert the (50 c) coins :");
            Console.Write("\r\n : ");
            input = Console.ReadLine();
            coin50 = int.Parse(input) * 50;
            SnacksVendingMachine.quantityOfFiftyCoin++;
            totalprice = coin1 + coin50 + coin10+ coin20;
            totalprice = totalprice / 100;
             Console.Clear();
             Console.WriteLine($"\r\n the total number of coins that you are payed is  :");
             Console.WriteLine(totalprice+"$");
             return totalprice;
        }
        private static int TakeNotes()
        {
            string input = "";
            int coin20 = 0;
            int coin50 = 0;
            int totalprice = 0;
            Console.Clear();
            Console.WriteLine($"\r\n please insert the (20 NIS) coins :");
            Console.Write("\r\n:");
            input = Console.ReadLine();
            coin20 = int.Parse(input)*2000;
            SnacksVendingMachine.quantityOfTwentyNotes++;
            Console.WriteLine($"\r\n please insert the (50 NIS) coins :");
            Console.Write("\r\n: ");
            input = Console.ReadLine();
            coin50 = int.Parse(input)*5000;
            SnacksVendingMachine.quantityOfFiftyNotes++;
            totalprice = coin20 + coin50 ;
            Console.Clear();
            Console.WriteLine($"\r\n the total number of Notes that you are payed is:");
            Console.WriteLine(totalprice);
            return totalprice;
        }

        public static double  RestOfMoney(double priceOfOrder,double CustomerMoney)
        {
          double rest = 0;
            if (priceOfOrder > CustomerMoney)
            {
                Console.WriteLine("Sorry you didn't pay enough money");
                Console.ReadLine();
            }
            else
            {

                rest= (int)((CustomerMoney - priceOfOrder)*100);
               

            }
            return rest;
        }
    }
}
