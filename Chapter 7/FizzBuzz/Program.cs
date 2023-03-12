for (int i = 1; i <= 10; i++)
{
    if (i % 3 == 0)
    {
         Console.WriteLine("Fizz");    
    }
    else if(i % 5 == 0)
    {
         Console.WriteLine("Buzz");    
    }
    else
    {
        Console.WriteLine(i);
    }
}