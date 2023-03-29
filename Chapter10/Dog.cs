public class Dog : Animal
{
    public bool Agitated { get; }

    public Dog(string animalType, string animalColor, int animalAge, bool agitated)
                : base(animalType, animalColor, animalAge)
    {
        Agitated = agitated;
    }

    public override void Speak()
    {
        if (Agitated)
        {
            Console.WriteLine("Growl");
        }

        else
        {
            Console.WriteLine("Woof!");
        }
    }
}