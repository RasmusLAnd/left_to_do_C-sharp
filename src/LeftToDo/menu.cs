using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Menu
    {    List<Item> ItemList= new List<Item>();  
        List<Done> DoneList = new List<Done>();   
        public void Start()
        {
            string myItem, status, change;
            int length;                 

            int choice;
            do 
            {
             Console.WriteLine("\n\t---------          Let To Do            -----------");

                    Console.WriteLine("\tList all of todays tasks        -           enter 1 ");
                    Console.WriteLine("\tAdd new Task to todays list     -           enter 2 ");
                    Console.WriteLine("\tFile all \"done\" tasks           -           enter 3 "); 
                    Console.WriteLine("\tList all filed (\"done\") tasks   -           enter 4 ");
                    Console.WriteLine("\tEnd program                     -           enter 9 ");
                    Console.Write("\tPlease enter your choice            -                   ");
                    
                    int.TryParse(Console.ReadLine(), out choice); 

                    switch (choice)
                        {
                            // Showing all items in the LTD-list    
                            case 1:
                            Console.WriteLine("Listing all items");

                            foreach (Item ltd in ItemList){                                                            
                                ltd.ShowProducts(); 
                            } 

                            Console.WriteLine("\n");
                            
                            Console.WriteLine("Do you wish to change status on one of the tasks? y/n");
                            change = Console.ReadLine().ToUpper();

                            switch(change){
                                case "Y":
                                
                                Console.WriteLine("What task must change status");
                                string searchWord;
                                Console.WriteLine("Enter search word...");
                                searchWord =Console.ReadLine();                        
                                
                                foreach(Item test in ItemList)
                                {   Console.WriteLine(test.myItem);
                                    if (test.myItem == searchWord)
                                    {test.status="d";
                                    Console.WriteLine(test.myItem);}
                                }
                                break;
                                case "N":break;
                            }  
                                                      
                            break;

                            // Adding an Item to the LTD-list
                            case 2:
                            Console.WriteLine("Add item to Todays list");

                            Console.WriteLine("What is the new task?");

                            myItem= Console.ReadLine();

                            Console.WriteLine("What is the status of the task - todo (t) or done (d)?");
                          
                            bool continuepar= false;
                            do
                            {
                                string temp = Console.ReadLine();

                                if (temp== "t" || temp == "d")
                                {
                                continuepar = true;
                                status = temp;                                     
                                      
                                length = ItemList.Count;//getting size of list
                                        
                                string id = (length + 1).ToString(); //creating ID
                                    
                                Item ltdList= new Item();
                                ltdList.Items(myItem, status, id);                                                         
                                ItemList.Add(ltdList); 

                                //print all elements in Itemlist
                                foreach(Item itm in ItemList)
                                {
                                Console.WriteLine(itm.myItem, itm.status, itm.id );
                                }                         
                                    
                                }
                                else
                                {Console.WriteLine("Invalid answer. Please enter t or d");}
                                
                            } while (continuepar == false);                     
                                                        
                            break;
                            
                            
                            case 3:
                            Console.WriteLine("File all done LTD-items");
                            FileAll();                          

                            break;

                            case 4:
                            Console.WriteLine("All done LTD-items\n");
                                                        
                            foreach (Done ltd2 in DoneList){
                                ltd2.ShowProducts();}                                                           
                            break;

                            case 9:
                            Console.WriteLine("Exiting Program");                            
                            break;

                            default:
                            Console.WriteLine("\n\tNot an option - try again  ");
                            break;
                        }

            }while (choice != 9);

            
        }
        
        public void FileAll()
        {
            Done donelist = new Done();
                            
            List<Item> newList = new List<Item>(ItemList);        //copy of itemlist to a new list               

            foreach (Item ltd in newList){
            Console.WriteLine(ltd.myItem, ltd.status, ltd.id);
            if(ltd.status == "d")   
                {
                donelist.Items(ltd.myItem, ltd.status, ltd.id);                                
                DoneList.Add(donelist);
                ItemList.Remove(ltd);
                }                          

            foreach(Item itm in ItemList)
            {
            Console.WriteLine(itm.myItem, itm.status, itm.id);
            }                              
            }
        }
    }
}