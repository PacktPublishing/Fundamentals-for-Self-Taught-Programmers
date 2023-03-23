/// <summary>
/// This is a description of the animal class
/// </summary>

public class Animal
{ 
    /// <value>
    /// Represents the animal type.
        /// <remarks>
        /// The <see cref="Type"/> is a <see langword="string"/>
        /// that you use to define any animal.
        /// <para>
        /// This property should not be used for
        /// a specific breed.
        /// </para>
        /// </remarks>
    /// </value>

    public string Type { get; }
    public string Color { get; }
    public int Age { get; set; }

    /// <summary>
    /// Mimics noises an animal makes.
    /// <remarks>
    /// Override this empty method.
    /// </remarks> 
    /// </summary>

    public virtual void Speak()
    {
    }
    
    /// <summary> 
    /// This is the default constructor.
    /// </summary>
    /// <param name="animalType">
    /// The type of animal.
    /// </param>
    /// <param name="animalColor">
    /// The color of the fur or skin of animal.
    /// </param>
    /// <param name="animalAge">
    /// The age of animal.
    /// </param>

    public Animal(string animalType, string animalColor, int animalAge) 
    {
        Type = animalType;
        Color = animalColor;
        Age = animalAge;
    }
}