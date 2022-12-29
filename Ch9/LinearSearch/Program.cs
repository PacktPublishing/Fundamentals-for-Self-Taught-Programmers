int[] testArray = {13, 55, 0, -4, 80, 7, 20};  
int searchValue = 0;

for (int index = 0; index < testArray.Length; index++)
{
    if(searchValue == testArray[index])
    {
        Console.WriteLine("Value found!");
    }
}

Console.WriteLine("Value not found!");
