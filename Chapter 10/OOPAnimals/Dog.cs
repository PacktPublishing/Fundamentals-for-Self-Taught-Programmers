public class Dog : Animal
{
    public bool Agitated { get; }

    public override void Speak()
    {
        if (Agitated)
        {
            Console.Write("Growl");
        }

        else
        {
            Console.Write("Woof!");
        }
    }

}