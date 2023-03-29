Animal cat = new Animal("Cat", "White", 2);

Console.WriteLine(cat.Age);

cat.Age = 3;
cat.Speak();

Cat milo = new Cat("Cat", "White", 3, true, "Shorthair");

Console.WriteLine(milo.Age);
Console.WriteLine(milo.Breed);
milo.Speak();

Invoice invoice = new Invoice(milo, 123);