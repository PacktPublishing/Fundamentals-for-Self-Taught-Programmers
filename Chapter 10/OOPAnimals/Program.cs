Animal cat = new Animal("Cat", "White", 2);

Console.Write(cat.Age);

cat.Age = 3;
cat.Speak();

Cat milo = new Cat("Cat", "White", 3, true, "Shorthair");

Console.Write(milo.Age);
Console.Write(milo.Breed);
milo.Speak();

Invoice invoice = new Invoice(milo, 123);