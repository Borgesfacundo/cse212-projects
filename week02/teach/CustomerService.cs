/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Queue -1 ("Adam", "ABC", "card declined"), ("Sophia", "DEF", "Battery dead"), ("Carlos", "GHI", "Needs a translator")
        // Expected Result: Adam, Sohpia, Carlos / Empty List
        Console.WriteLine("Test 1");
        var cs = new CustomerService(-1);
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        //Check what is in the customerService()
        Console.WriteLine(cs);
        //Delete Adam
        cs.ServeCustomer();
        //Delete Sohpia
        cs.ServeCustomer();
        //Delete Carlos
        cs.ServeCustomer();

        //Check if Queue is empty
        Console.WriteLine(cs);

        cs.ServeCustomer();

        // Defect(s) Found: in ServeCustomer() It was displaying the next customer in Queue and not the removed one. 
        //And It was missing an if statment to verify if queue is empty to print an error message.

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Queue of 1 value and we will try to add 2 customers. Adam and Sophia
        // Expected Result: Adam, "list is full"
        Console.WriteLine("Test 2");

        var cs2 = new CustomerService(1);
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        Console.WriteLine(cs2);

        //Delete the unique value
        cs2.ServeCustomer();
        Console.WriteLine(cs2);



        // Defect(s) Found: in AddNewCustommer() the if statment was trying to add a new value even when queue was full (queue.count > maxSize)

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {
        if (_queue.Count == 0) //I added this if statment to verify if queue is empty to print an error message
        {
            Console.WriteLine("Queue is empty :D");
        }
        else
        {
            var customer = _queue[0];  //Here I need to get the customer deleted not the next customer. So I need to chmove this linne before the remove()
            _queue.RemoveAt(0);
            Console.WriteLine(customer);
        }
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}