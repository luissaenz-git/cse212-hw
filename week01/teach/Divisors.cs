public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        // TODO problem 1
        //pseudocode
        //for each integer in the range from 1 to the specified number
        //if the specified number is divisible by the number or is different from the original number
        //add the number to the results list
        //if not discard it

        //Implementation
        //For i starting at 1, while i is less than or equal to 3, increment i by 1 each time.
        for (int i = 1; i <= number; i++)
        {
          if (number%i == 0 && i != number)
            {
               results.Add(i); 
            }  
        }
        return results;
    }
}