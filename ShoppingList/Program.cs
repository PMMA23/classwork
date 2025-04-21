namespace ShoppingList;

class Program
{
    static void Main(string[] args)
    {

        // Step 1: Make a menu w/ items names and prices
        // Dictionary<item, name, price> ( Dictionary is used because each items has a name and price)

        Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

        // Add 8 items 
        menu["Salmon"] = 8.99m;
        menu["Broccolini"] = 2.49m;
        menu["Steak"] = 9.99m;
        menu["Mash Potatoes"] = 4.99m;
        menu["Rice"] = 3.99m;
        menu["Hot Sauce"] = 5.99m;
        menu["Water"] = 7.99m;
        menu["Rice Cakes"] = 2.89m;
        menu["Peanut Butter"] = 6.49m;


        // Step 2: Make a shopping list 
        // list is used to store all items user chooses 

        List<string> shoppingList = new List<string>();

        //Step 3: Show the menu so user knows what to choose from

        Console.WriteLine("Welcome to the store here is the menu:");
        Console.WriteLine("");

        foreach (KeyValuePair<string, decimal> item in menu)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }

        string userInput = "";

        while (true)
        {
            Console.WriteLine("Please enter an item to add to your shopping list:"); // Check if item is in menu

            userInput = Console.ReadLine();

            if (menu.ContainsKey(userInput)) //Check ig item is in the menu
            {
                shoppingList.Add(userInput); //Adding item to list
                Console.WriteLine(userInput + "added to your shopping list");
            }
            else
            {
                Console.WriteLine("Sorry that item is not on the menu. Try again.");
            }
            // Step 5 : Show all items user picked with prices 
            // add up total 

            Console.WriteLine("Here is your receipt");
            Console.WriteLine("");

            decimal totalPrice = 0;

            foreach (string item in shoppingList)
            {
                decimal price = menu[item];
                Console.WriteLine(item + " - " + price);
                totalPrice += price;
            }

            Console.WriteLine("");
            Console.WriteLine("Total price is: " + totalPrice);

            Console.WriteLine(" Press any key to exit...");
            Console.ReadKey();
            
            // Extra
            //if (shoppingList.Count > 0)
            //{
            //    string mostExpensiveItem = shoppingList[0];
            //    string leastExpensiveItem = shoppingList[0];

            //    foreach (string item in shoppingList) ;
            //    {
             //       if (menu[item] < menu [leastExpensiveItem])
              //  }
            }     
            
            
            
        }
    }