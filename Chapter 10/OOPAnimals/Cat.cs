public class Cat : Animal 
{ 
    public bool Polydactyl {get;}
    public string Breed {get;}

    public Cat(string animalType, string animalColor, int animalAge, bool polydactyl, string breed) 
                : base(animalType, animalColor, animalAge) 
    { 
        Polydactyl = polydactyl; 
        Breed = breed; 
    } 

    public override void Speak() 
    {  
        Console.Write("Meow");  
    }  

} 