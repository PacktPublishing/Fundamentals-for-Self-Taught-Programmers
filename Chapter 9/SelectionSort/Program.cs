int[] testArray = {13, 55, 0, -4, 80, 7, 20};

for (int index = 0; index < testArray.Length; index++)
{
    int minIndex = index; 
    int minValue = testArray[index]; 
    // Console.WriteLine(testArray[index]);

    for (int unsortedIndex = index + 1; unsortedIndex < testArray.Length; unsortedIndex++)
    {
            // Console.WriteLine("Unsorted value:" + testArray[unsortedIndex]);
            if (testArray[unsortedIndex] < minValue)
            {
                minIndex = unsortedIndex;
                minValue = testArray[unsortedIndex];
            }

    }

    int tempValue = testArray[index]; 
    testArray[index] = testArray[minIndex]; 
    testArray[minIndex] = tempValue; 
}

Array.ForEach(testArray, Console.WriteLine);