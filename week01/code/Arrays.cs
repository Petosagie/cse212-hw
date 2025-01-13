public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    /// Plan to Implement MultiplesOf Function
    /// Inputs and Outputs
    /// Inputs: A double (number) representing the starting value and an int (length) representing the number of multiples to calculate.
    /// Output: A double[] containing length multiples of number.

    /// Logic:
    /// Create an empty array to store the multiples.
    /// Use a loop to calculate the multiples of number.
    /// Start from the number.
    /// Multiply number by the loop index and store it in the array.
    /// Return the array after the loop completes.
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        {
            // Create an array to hold the multiples.
            double[] multiples = new double[length];

            // Loop through and calculate multiples of 'number'.
            for (int i = 0; i < length; i++)
            {
                // Each multiple is the starting number times the (index + 1).
                multiples[i] = number * (i + 1);
            }

            //  Return the array of multiples.
            return multiples;
        }



    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>

    /// Inputs and Outputs:
    /// Inputs: A List<int> (data) and an int (amount) indicating how many positions to rotate the list to the right.
    /// Output: The original list modified in place.

    /// Logic:
    /// Assign the rotation amount using the modulo operator (%) to handle cases where the amount exceeds the list length.
    /// Split the list into two parts:
    /// The last amount elements.
    /// The remaining elements from the start.
    /// Rearrange the list by appending the first part to the second.

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Assign amount to handle cases where amount > data.Count.
        amount = amount % data.Count;

        // Get the last 'amount' elements as a new list.
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Get the remaining elements from the start of the list.
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Clear the original list and append the rearranged parts.
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);

    }
}
