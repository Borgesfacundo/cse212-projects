public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Giving 3 values in which the value with highest priority has the highest priority.
        // Expected Result:  John, Kevin, Bryan
        Console.WriteLine("Test 1");
        var values = new PriorityQueue();

        values.Enqueue("Kevin", 3);
        values.Enqueue("John", 7);
        values.Enqueue("Bryan", 2);
        Console.WriteLine(values);

        Console.WriteLine("1st deleted");
        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values);

        Console.WriteLine("2nd deleted");
        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values);

        Console.WriteLine("3rd deleted");
        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values);

        Console.WriteLine("Should be Empty now");
        Console.WriteLine(values);


        // Defect(s) Found: Dequeue() was not removing the highest priority value from the List.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}