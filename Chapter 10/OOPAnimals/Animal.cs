public class Animal 
{ 
    public string Type {get;} 
    public string Color {get;} 
    public int Age {get; set;} 

    public virtual void Speak() 
    { 
    } 

    public Animal(string animalType, string animalColor, int animalAge) 
    { 
        Type = animalType; 
        Color = animalColor; 
        Age = animalAge; 
    } 
} 