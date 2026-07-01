public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        //pseudocode
        //create an array based on the select array capacity to store results
        //use var select as reference
        //create indexes from both array to know where to copy
        //iterate each value from the selector list
        //if the value is one copy a value from the array 1 and increase its index variable
        //the same for the array 2
        //return the result array at the end

        var result = new int [select.Length];

        int index1 = 0;
        int index2 = 0;

        for (var index = 0; index < select.Length; ++index)
        {
            int currentValue = select[index];
            if (currentValue == 1)
            {
                int value1 = list1[index1];

                result[index] = value1;

                ++index1;
                 
            }
            else if (currentValue == 2)
            {
                int value2 = list2[index2];

                result[index] = value2;

                ++index2;
            } 
        }


        return result;
    }
}