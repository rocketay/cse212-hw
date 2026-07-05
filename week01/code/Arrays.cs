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
        // Plan:
        // 1. Create a new double array with size 'length' to hold the results.
        // 2. Loop from index 0 up to (but not including) 'length'.
        // 3. Each multiple is 'number' times its position (1-based). Since the loop
        //    index starts at 0, the multiplier is (index + 1).
        //    Example: number = 7 -> 7*1, 7*2, 7*3, ...
        // 4. Store each computed multiple into the array at the current index.
        // 5. After the loop finishes, return the array.

        // 1. Create the array to hold the multiples
        double[] multiples = new double[length];

        // 2. Loop through each position in the array
        for (var i = 0; i < length; ++i)
        {
            // 3 & 4. Compute the multiple (number * position) and store it
            multiples[i] = number * (i + 1);
        }

        // 5. Return the finished array
        return multiples;
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
        // TODO Problem 2 Start
        // Plan (using list slicing):
        // 1. Rotating right by 'amount' means the last 'amount' items move to the front,
        //    and the rest of the items follow behind them.
        //    Example: {1..9} rotated by 3 -> last 3 {7,8,9} go to the front,
        //    then the first 6 {1,2,3,4,5,6} follow -> {7,8,9,1,2,3,4,5,6}.
        // 2. Get the last 'amount' items as a slice. They start at index
        //    (data.Count - amount) and continue to the end.
        // 3. Get the remaining items as a slice: from index 0 up for (data.Count - amount) items.
        // 4. Clear the original list and add the last part first, then the first part.

        // 2. Slice of the last 'amount' items (these go to the front)
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // 3. Slice of the remaining items (these go after)
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // 4. Rebuild the list: last part first, then the first part
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}