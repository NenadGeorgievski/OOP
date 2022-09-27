using AbstractClasses;

Console.WriteLine("PLease enter your dog's name:");

string dog = Console.ReadLine();

Dog dogObj = new Dog();
dogObj.setName(dog);

dogObj.Eat();
Console.WriteLine($"Your dog's name is: {dogObj.getName()}");