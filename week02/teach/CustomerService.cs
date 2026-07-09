/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Include the 0 as max size to verify if the default value is used (10)
        // Expected Result: It must use 10 as the maxsize by default
        Console.WriteLine("Test 1");

        var cs = new CustomerService(0);
        Console.WriteLine(cs);

        // Defect(s) Found: None, working correctly

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Include a customer 4 to a maxsize of 3
        // Expected Result: It must not allow this operation
        Console.WriteLine("Test 2");

        var service = new CustomerService(3);
        service.AddNewCustomer();
        service.AddNewCustomer();
        service.AddNewCustomer();
        service.AddNewCustomer();
        
        Console.WriteLine($"Service Queue: {service}");


        // Defect(s) Found: It allows to add an extra customer to the queue, even if the maxsize is 3. It should not allow this operation.

        Console.WriteLine("=================");

        // Test 3
        // Scenario: As input include an ordered list of customers
        // Expected Result: Verify that the program maintains this order
        Console.WriteLine("Test 3");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 4
        // Scenario: All orders were finished and there are no more customers on the queue. Try to call a customer on this scenario
        // Expected Result: An error meesage will be displayed
        Console.WriteLine("Test 4");

        var service4 = new CustomerService(5);
        service4.AddNewCustomer();
        service4.ServeCustomer();
        Console.WriteLine("Should return an error message.");

        // Defect(s) Found: It does not detect that there are no more customers on the queue and it tries to serve a customer, which will throw an exception.

        Console.WriteLine("=================");

        // Test 5
        // Scenario: Add customers to the queue and serve them.
        // Expected Result: Customers should be served in the same order they were added (FIFO).
        Console.WriteLine("Test 5");
        CustomerService cs5 = new CustomerService(3);
        // Add three customers
        cs5.AddNewCustomer();
        cs5.AddNewCustomer();
        cs5.AddNewCustomer();
        // Serve customers
        cs5.ServeCustomer();   // Should serve Faith
        cs5.ServeCustomer();   // Should serve Foi
        cs5.ServeCustomer();   // Should serve Mary
        // Defect(s) Found:
        // None if the customers are served in the same order they were added.
        Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
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
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}