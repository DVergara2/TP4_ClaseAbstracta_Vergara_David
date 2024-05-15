// Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
    public abstract void animalType();
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
    public override void animalType()
    {
        Console.WriteLine("Type: mamifero");
    }

}

class Burro : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The burro says: Iiiig oooooh");
    }
    public override void animalType()
    {
        Console.WriteLine("Type: mamifero");
    }
}
class oso : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The oso says: wrorrrrrr");
    }
    public override void animalType()
    {
        Console.WriteLine("Type: mamifero");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();
        myPig.animalType();// Call the abstract method
        myPig.sleep();  // Call the regular method

        Burro myburro = new Burro();
        myburro.animalSound();
        myburro.animalType();
        myburro.sleep();

        oso myoso = new oso();
        myoso.animalSound();
        myoso.animalType();
        myoso.sleep();
    }

}
