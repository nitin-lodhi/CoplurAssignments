using System;
using System.Collections;


interface IFoodItem
{
    private static int ctr { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public double price { get; set; }
}
class FoodItem : IFoodItem
{
    private static int ctr { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public double price { get; set; }

    public FoodItem(string name, string category, double price)
    {
        ctr += 1;
        this.id = ctr;
        this.name = name;
        this.category = category;
        this.price = price;
    }
}

class Order
{
    private static int ctr;
    public int orderId;
    public int custId;
    FoodItem foodItem;
    public bool isDelivered;
    public Order(int custId, FoodItem foodItem, bool isDelivered)
    {
        ctr += 1;
        this.custId = custId;
        this.orderId = ctr;
        this.foodItem = foodItem;
        this.isDelivered = isDelivered;
    }
}

interface ICustomer
{
    public int custId { get; set; }
    public void placeOrder(string foodName, ERestaurant eRestaurant);
}
class Customer : ICustomer
{
    private static int ctr;
    public int custId { get; set; }
    public Customer()
    {
        ctr += 1;
        custId = ctr;
    }
    public void placeOrder(string foodName, ERestaurant eRestaurant)
    {
        FoodItem foodItem = eRestaurant.menu.Find(food => food.name == foodName);

        if (foodItem == null)
        {
            Console.WriteLine("Not in Menu.");
            return;
        }

        Order order = new Order(custId, foodItem, false);
        eRestaurant.pendingOrders.Enqueue(order);
        Console.WriteLine($"Order Placed Successfully.");
    }
}

interface IRestaurant
{
    public List<FoodItem> menu { get; set; }
    public Dictionary<int, List<FoodItem>> customerOrder { get; set; }
    public Queue<Order> pendingOrders { get; set; }
    public Stack<Order> deliveredOrders { get; set; }
    public HashSet<string> uniqueFood { get; set; }
    public void addFoodItems(FoodItem foodItem);
    public void showMenu();
    public void showFoodCategories();
    public void deliverOrder();
    public void showPendingDeliveries();
    public void showDeliveredOrders();
}
class ERestaurant : IRestaurant
{

    public List<FoodItem> menu { get; set; } = new List<FoodItem>();
    public Dictionary<int, List<FoodItem>> customerOrder { get; set; } = new Dictionary<int, List<FoodItem>>();
    public Queue<Order> pendingOrders { get; set; } = new Queue<Order>();
    public Stack<Order> deliveredOrders { get; set; } = new Stack<Order>();
    public HashSet<string> uniqueFood { get; set; } = new HashSet<string>();

    public void addFoodItems(FoodItem foodItem)
    {
        menu.Add(foodItem);
        uniqueFood.Add(foodItem.category);
    }

    public void addFoodItems()
    {
        Console.WriteLine("Enter Food Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Food Category");
        string category = Console.ReadLine();
        Console.WriteLine("Enter Food Price");
        double price = double.Parse(Console.ReadLine());

        FoodItem foodItem = new FoodItem(name, category, price);
        menu.Add(foodItem);
        uniqueFood.Add(foodItem.category);
        Console.WriteLine($"{name} {category} {price} added Successfully.");
    }

    public void showMenu()
    {
        Console.WriteLine("ID         Name          Category          Price");
        foreach (FoodItem item in menu)
        {

            Console.WriteLine($"{item.id}         {item.name}          {item.category}          {item.price}");
        }
    }
    public void showFoodCategories()
    {
        Console.WriteLine("<-----Food Categories---->");
        foreach (string cat in uniqueFood)
        {
            Console.WriteLine(cat);
        }
    }

    public void deliverOrder()
    {
        if (pendingOrders.Count != 0)
        {
            Order order = pendingOrders.Peek();
            pendingOrders.Dequeue();
            order.isDelivered = true;
            deliveredOrders.Push(order);
            Console.WriteLine($"Order of orderId: {order.orderId} Delivered Successfully.");
        }else{
            Console.WriteLine($"There are no Orders to Deliver.");
        }

    }
    public void showPendingDeliveries()
    {
        Queue<Order> temp = new Queue<Order>(pendingOrders);

        if (temp.Count == 0)
        {
            Console.WriteLine("No Pending Orders.");
            return;
        }

        while (temp.Count != 0)
        {
            Console.WriteLine($"Pending Order ID: {temp.Peek().orderId}");
            temp.Dequeue();
        }
    }
    public void showDeliveredOrders()
    {
        Stack<Order> temp = new Stack<Order>(deliveredOrders);

        if (temp.Count == 0)
        {
            Console.WriteLine("No Delivered Orders.");
            return;
        }

        while (temp.Count != 0)
        {
            Console.WriteLine($"Delivered Order ID: {temp.Peek().orderId}");
            temp.Pop();
        }
    }
}



class Program
{
    public static void Main(string[] args)
    {

        ERestaurant eRestaurant = new ERestaurant();
        eRestaurant.addFoodItems(new FoodItem("Pizza", "Fast_Food", 420));
        eRestaurant.addFoodItems(new FoodItem("Burger", "Fast_Food", 280));
        eRestaurant.addFoodItems(new FoodItem("Pasta", "Italian", 350));
        eRestaurant.addFoodItems(new FoodItem("Lasagna", "Italian", 400));
        eRestaurant.addFoodItems(new FoodItem("Sushi", "Japanese", 600));
        eRestaurant.addFoodItems(new FoodItem("Ramen", "Japanese", 450));
        eRestaurant.addFoodItems(new FoodItem("Biryani", "Indian", 300));
        Customer customer = new Customer();

        bool flag = false;


        while (true)
        {
            Console.WriteLine("<---Enter User Type (1,2 or 3)--->");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");

            string type = Console.ReadLine();

            if (type == "1")
            {
                flag = true;
                while (flag)
                {
                    Console.WriteLine("<--- Enter Employee's Work (1,2,3,4,5,6,7) --->");
                    Console.WriteLine("1. See Food Item");
                    Console.WriteLine("2. See Food Categories");
                    Console.WriteLine("3. Add Food Item");
                    Console.WriteLine("4. See Pending Orders");
                    Console.WriteLine("5. See Delivered Orders");
                    Console.WriteLine("6. Deliver the Order");
                    Console.WriteLine("7. Exit");

                    string work = Console.ReadLine();

                    switch (work)
                    {
                        case "1":
                            eRestaurant.showMenu();
                            break;
                        case "2":
                            eRestaurant.showFoodCategories();
                            break;
                        case "3":
                            eRestaurant.addFoodItems();
                            break;
                        case "4":
                            eRestaurant.showPendingDeliveries();
                            break;
                        case "5":
                            eRestaurant.showDeliveredOrders();
                            break;
                         case "6":
                            eRestaurant.deliverOrder();
                            break;
                        case "7":
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Work!!");
                            break;

                    }
                }
            }
            else if (type == "2")
            {
                flag = true;
                while (flag)
                {
                    Console.WriteLine("<--- Enter User's Work (1,2,3,4,5,6,7) --->");
                    Console.WriteLine("1. See Food Menu");
                    Console.WriteLine("2. See Food Categories");
                    Console.WriteLine("3. Place order");
                    Console.WriteLine("4. Exit");

                    string work = Console.ReadLine();

                    switch (work)
                    {
                        case "1":
                            eRestaurant.showMenu();
                            break;
                        case "2":
                            eRestaurant.showFoodCategories();
                            break;
                        case "3":
                            Console.WriteLine("Enter Food Name: ");
                            string name = Console.ReadLine();
                            customer.placeOrder(name, eRestaurant);
                            break;
                        case "4":
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Work!!");
                            break;
                    }
                }

            }
            else if (type == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid type!!");
                break;
            }
        }

    }
}
