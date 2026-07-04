using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        //***DESIGN***
        // To implement the code we must cosider first the input and outputs, according to that we can start develop  the process
        // INPUT
        // Give me the first 5 multiples of 3
        // OUTPUT
        // An array of 1x1 that includes multiples of 3
        // PROCESS
        // ---Variables---
        // Number 3
        // Quantity 5
        // ---Algorithm----
        // Number 3x1, Number 3x2, Number 3x3, Number 3x4, Number 3x5
        // ---Condition----
        // While the number that is being multiplied by 3 is less that the quantity of 5 it still needs to multiply
        //--Index---
        //Due to the results will be stored in an array we need an index to store them in each field of the array
        //to do that we will use and a variable i that will work as the number to multiply
        //and this variable i wil be substracted by 1 and store in a variable index so we can store the data properly in each field of the array
        //The array capacity will depend on the length the user will provide

        double[] results = new double[length];

        for (double i = 1; i <= length; i++)
        {
            double multiple = i*number;
            int index = (int)(i-1);
            results[index] = multiple;
        }
        return results; // replace this return statement with your own
    }

    

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {

        //***DESIGN***
        // To implement the code we must cosider first the input and outputs, according to that we can start develop  the process
        // INPUT
        // A list or dynamic array with some ints and an amount of times that it must be Rotated
        // OUTPUT
        // A list rotated to the right according to the amount of times given
        // PROCESS
        // ---Variables---
        // Number of Rotations
        // A variable to store the size of the given list
        // An empty list to store the rotated list
        // A variable of the actual index number that is equal to the size of the given list minus 1
        // ---Algorithm----
        // Copy the last index number from the original list to the new empty list 
        // Then while the index to copy the original list is less than the actual index number
        // Copy the value from the orignal list using the index to copy minus 1 to the new rotated list
        // This will be repeated the amount of times given
        // Once the rotation was executed clear the original List and copy th data from the rotated List to the empty current list
        // Then clear the rotated list to repeat the process  

        int rotationsNumber = amount;

        //List<int> currentList = data;

        List<int> rotatedList = new List<int> ();

        int lengthList = data.Count;

        for(int i=1; i<= rotationsNumber; i++)
        {
            rotatedList.Clear();
            int rotatedIndex = lengthList-1;

            //rotatedList.Insert(0, data[rotatedIndex]);
            rotatedList.Add(data[rotatedIndex]);
        
            for(int j=1; j<=rotatedIndex; j++)
            {
                //rotatedList.Insert(j, data[j-1]);
                rotatedList.Add(data[j-1]);
            }
        
            data.Clear();
            data.AddRange(rotatedList);

        }
    }

    
}
