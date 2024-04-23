namespace Test
{
    public class Dog 
    {
        public Dog(string name) 
        {   
            Name = name;
        }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog=new Dog("Destroyer");
            Console.WriteLine(dog.Name);
        }
    }
}