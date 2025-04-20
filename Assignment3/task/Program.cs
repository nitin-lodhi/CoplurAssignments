public class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer(101, "Nitin", "Lodhi", "nitin@gmail.com", CustomerType.Silver);

        RegisterCustomer registerCustomer = DataFactory.GetNewRegisterCustomer();
        
        registerCustomer.Register(customer);

        // DiscountToCustomer discountToCustomer = DataFactory.GetNewDiscountToCustomer();
        // int discount = discountToCustomer.GetDiscountPercentage(customer.Type);
        // Console.WriteLine(discount);

        Process process = DataFactory.GetNewProcess();
        process.ProcessOrder(customer);

    }
}


interface ICustomer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
interface ICustomerType {
       public CustomerType Type { get; set; }
}
public class Customer : ICustomer,ICustomerType
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public CustomerType Type { get; set; } = CustomerType.Normal;

    public Customer(int customerId, string firstName, string lastName, string email, CustomerType type)
    {
        this.CustomerId = customerId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Type = type;
    }

}

interface IRegister
{
    public void Register(Customer cust);
}

public class RegisterCustomer : IRegister
{  
    public void Register(Customer cust)
    {
        try
        {
            if (cust.Type == CustomerType.Bronze)
            {
                //some logic
            }

            if (cust.Type == CustomerType.Silver)
            {
                //some logic
            }

            if (cust.Type == CustomerType.Gold)
            {
                //some logic
            }

            if (cust.Type == CustomerType.Platinum)
            {
                //some logic
            }
            ISave saveCustomerToDB = DataFactory.GetNewSaveCustomerToDB();
            // Save to DB
            saveCustomerToDB.SaveCustomer(cust);
        }
        catch (Exception ex)
        {
            //Logger 
            Console.WriteLine($"Log Error: {ex.Message}");
        }
    }

}

interface ISave
{
    public bool SaveCustomer(Customer cust);
}
public class SaveCustomerToDB : ISave
{
    public bool SaveCustomer(Customer cust)
    {
        //save customer details to database
        // Console.WriteLine($"Name : {cust.FirstName}");
        // Console.WriteLine($"Email : {cust.Email}");
        Console.WriteLine("Data saved to database.");
        return true;
    }
}

interface IDiscount
{
    public int GetDiscountPercentage(CustomerType type);
}

public class DiscountToCustomer : IDiscount
{
    public int GetDiscountPercentage(CustomerType type)
    {
        if (type == CustomerType.Bronze)
        {
            return 15;
        }
        else if (type == CustomerType.Silver)
        {
            return 20;
        }
        else if (type == CustomerType.Gold)
        {
            return 25;
        }
        else if (type == CustomerType.Platinum)
        {
            return 27;
        }
        return 12;
    }
}

interface IProcess
{
      public void ProcessOrder(Customer cust);
}

public class Process: IProcess
{
    public void ProcessOrder(Customer cust)
    {
        IDiscount discountToCustomer = DataFactory.GetNewDiscountToCustomer();
        int discount = discountToCustomer.GetDiscountPercentage(cust.Type);
        Console.WriteLine(discount);

        //Process Payment after Discount
        //Send confirmation
        //Log Order Activity
        Console.WriteLine("Order Placed Successfully");
    }
}

public enum CustomerType
{
    Bronze,
    Silver,
    Gold,
    Platinum,
    Normal
}

public static class DataFactory {
     public static RegisterCustomer GetNewRegisterCustomer() {
               return new RegisterCustomer();
     }

     public static SaveCustomerToDB GetNewSaveCustomerToDB() {
               return new SaveCustomerToDB();
     }
     
     public static DiscountToCustomer GetNewDiscountToCustomer() {
               return new DiscountToCustomer();
     }
     
     public static Process GetNewProcess() {
               return new Process();
     }
}

// public class Program
// { 
//     public static void Main(string[] args)
//     {
//               Customer customer = new Customer(
//                  CustomerID = 1;
//                  FirstName = "Nitin";
//                  LastName = "Lodhi";
//                  Email = "nitin@gmail.com";
//                  Type = CustomerType.Silver;
//               );

//               customer.
//     }
// }
// public class Customer
// {
//     public int CustomerId { get; set; }
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string Email { get; set; }
//     public CustomerType Type { get; set; }

//     public void Register(Customer cust)
//     {
//         try
//         {
//             if (cust.Type == CustomerType.Bronze)
//             {
//                 //some logic
//             }

//             if (cust.Type == CustomerType.Silver)
//             {
//                 //some logic
//             }

//             if (cust.Type == CustomerType.Gold)
//             {
//                 //some logic
//             }

//             if (cust.Type == CustomerType.Platinum)
//             {
//                 //some logic
//             }

//             SaveCustomer();

//         }
//         catch (Exception ex)
//         {
//             //Logger 
//             Console.WriteLine($"Log Error: {ex.Message}");
//         }
//     }

//     public virtual bool SaveCustomer()
//     {
//         //save customer details to database
//         return true;
//     }

//     public int GetDiscountPercentage()
//     {
//         if (this.Type == CustomerType.Bronze)
//         {
//             return 15;
//         }

//         if (this.Type == CustomerType.Silver)
//         {
//             return 20;
//         }

//         if (this.Type == CustomerType.Gold)
//         {
//             return 25;
//         }

//         if (this.Type == CustomerType.Platinum)
//         {
//             return 27;
//         }

//         return 12;
//     }

//     public void ProcessOrder(Customer cust)
//     {
//         GetDiscountPercentage();
//         //Process Payment after Discount
//         //Send confirmation
//         //Log Order Activity
//         Console.WriteLine("Order Placed Successfully");
//     }
// }

// public class Leads : Customer
// {
//     //It is just a lead so need to save it in the database
//     public void GetDiscount()
//     {
//         int discount = GetDiscountPercentage();
//     }

//     public void ProcessOrder()
//     {
//         //some logic
//     }
// }

// public enum CustomerType
// {
//     Bronze,
//     Silver,
//     Gold,
//     Platinum
// }