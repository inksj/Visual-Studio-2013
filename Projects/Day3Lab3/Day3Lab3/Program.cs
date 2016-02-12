using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab3
{
    class Program
    {static List<Button> inventoryList = new List<Button>();
        static void Main(string[] args)
        {
            
            
            Button but1 = new Button();
            but1.partNumber = "348A14";
            but1.description = "Blue button";
            but1.numOfButtons = 300;
            but1.priceOfButton=0.50;
            inventoryList.Add(but1);
            System.Console.WriteLine("******Button 1******\n"+inventoryList[0].partNumber + "\n"+inventoryList[0].description + "\n"+ inventoryList[0].numOfButtons + "\n"+ inventoryList[0].priceOfButton);

            Button but2 = new Button();
            but2.partNumber = "5555";
            but2.description = "Yellow button";
            but2.numOfButtons = 500;
            but2.priceOfButton = 0.60;
            inventoryList.Add(but2);
            System.Console.WriteLine("******Button 2******\n"+inventoryList[0].partNumber + "\n" + inventoryList[0].description + "\n" + inventoryList[0].numOfButtons + "\n" + inventoryList[0].priceOfButton);
           
        
             System.Console.WriteLine("Type START to begin");
           string start =  System.Console.ReadLine();

           while (start == "START")
           {
               foreach (Button element in inventoryList)
               {
                   System.Console.WriteLine("Button " + element.partNumber);
               }
           
            System.Console.WriteLine("Type CREATE to make a new button, ORDER to place an order, UPDATE to change the price or q to quit");
            string resp = System.Console.ReadLine();
            
         if (resp == "CREATE")
                    {
                     newButton();
                    }
                    else if (resp == "ORDER")
                    {
                        placeOrder();
                    }
                else if (resp == "UPDATE")
                     {
                         updatePrice();
                     }
                    else
                    {
                        start = "END";
                    }
        }
        }
    static void newButton()
        {
            List<Button> inventoryList = new List<Button>();
          
            System.Console.WriteLine("What is the button's part number?");
            string part = System.Console.ReadLine();
            System.Console.WriteLine("What is the button's color?");
           string color = System.Console.ReadLine();
            System.Console.WriteLine("How many buttons in stock?");
            int stock = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Price per button:");
           double price = Convert.ToDouble(System.Console.ReadLine());

        Button newButton = new Button();
        newButton.partNumber = part;
             newButton.description = color;
             newButton.numOfButtons = stock;
             newButton.priceOfButton=price;
             inventoryList.Add(newButton);

            }
    static void placeOrder()
        {
            System.Console.WriteLine("What's the new price for the button? ");
            string partNum = System.Console.ReadLine();
            int index=-1;
        for ( int i= 0; i < inventoryList.Count; i++)
            {
            if ( inventoryList[i].partNumber==partNum)
                {
                    index=i;
                }
                
            }
            System.Console.WriteLine("How many buttons do you want?");
            int amountSold = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("This order costs $" + (inventoryList[index].priceOfButton* amountSold));
        inventoryList[index].numOfButtons=inventoryList[index].numOfButtons-amountSold;
            
            
        }//ends placeOrder method

    static void updatePrice()
        {
            System.Console.WriteLine("Enter in the part number");
            string partNum = System.Console.ReadLine();
            int index=-1;
            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (inventoryList[i].partNumber == partNum)
                {
                    index = i;
                }

            }
            System.Console.WriteLine("Price of Button "+ inventoryList[index].partNumber + "is" + inventoryList[index].priceOfButton);
            System.Console.WriteLine("Enter in new price: " );
            double newPrice = Convert.ToDouble(System.Console.ReadLine());

            inventoryList[index].priceUpdate(newPrice);
            System.Console.WriteLine("New price of button " + inventoryList[index].partNumber + "is " + inventoryList[index].priceOfButton);
        }    
         }
        
    }

