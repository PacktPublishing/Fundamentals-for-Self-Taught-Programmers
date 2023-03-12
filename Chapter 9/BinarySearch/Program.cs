int[] testArray = {-4, 0, 7, 13, 20, 55, 80};
int lowerHalfIndex = 0;
int upperHalfIndex = testArray.Length - 1;

while(lowerHalfIndex <= upperHalfIndex)
{
    int midpointIndex = lowerHalfIndex + (upperHalfIndex - lowerHalfIndex)/2;
    int searchValue = 55;

    if (testArray[midpointIndex] > searchValue )
    {
        upperHalfIndex = midpointIndex - 1;
    }

    else if(testArray[midpointIndex] < searchValue)
    {
        lowerHalfIndex = midpointIndex + 1;
    }

    else 
    {
        Console.WriteLine("Your value was found!");
        break;
    }
}

if (lowerHalfIndex > upperHalfIndex) 
{ 
        Console.WriteLine("Your value was not found!"); 
} 