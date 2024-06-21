public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Giving 3 values in which the value with highest priority has the highest priority.
        // Expected Result:  John / Kevin / Bryan
        Console.WriteLine("Test 1");
        var values = new PriorityQueue();

        values.Enqueue("Kevin", 3);
        values.Enqueue("John", 7);
        values.Enqueue("Bryan", 2);
        Console.WriteLine(values);

        Console.WriteLine("1st deleted");
        Console.WriteLine(values.Dequeue());

        Console.WriteLine("2nd deleted");
        Console.WriteLine(values.Dequeue());

        Console.WriteLine("3rd deleted");
        Console.WriteLine(values.Dequeue());

        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values);



        // Defect(s) Found: Dequeue() was not removing the highest priority value from the List.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Giving 3 values and the first and third have the same priority
        // Expected Result: Pedro / Simon / Juan / Santiago
        Console.WriteLine("Test 2");
        var values2 = new PriorityQueue();

        values2.Enqueue("Juan", 9);
        values2.Enqueue("Pedro", 10);
        values2.Enqueue("Santiago", 9);
        values2.Enqueue("Simon", 10);
        Console.WriteLine(values2);


        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(values2.Dequeue());
        }
        Console.WriteLine(values2);
        Console.WriteLine(values2.Dequeue());


        // Defect(s) Found: Dequeue() In case 2 numbers had same priority it was taking the last one and not the first one. And the list.Count was ignoring first value.  

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}