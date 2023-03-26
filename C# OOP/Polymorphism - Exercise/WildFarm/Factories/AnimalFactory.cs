namespace WildFarm.Factories
{
    using System;

    using Models.Interfaces;
    using Interfaces;
    using WildFarm.Models.Animals;
    using WildFarm.Models.Animals.Mammal;

    public class AnimalFactory : IAnimalFactory
    {
        IAnimal IAnimalFactory.CreateAnimal(string[] tokens)
        {
            string type = tokens[0];
            string name = tokens[1];
            double weight = double.Parse(tokens[2]);
            string argument=tokens[3];

            IAnimal animal = null;
            switch (type)
            {
                case "Owl":
                    animal = new Owl(name, weight, double.Parse(argument));
                    break;
                case"Hen":
                    animal = new Hen(name, weight, double.Parse(argument));
                    break;
                case "Mouse":
                    animal = new Mouse(name, weight,argument);
                    break;
                case "Dog":
                    animal=new Dog(name, weight, argument);
                    break;
                case "Cat":
                    string catBreed=tokens[4];
                    animal = new Cat(name, weight, argument, catBreed);
                    break;
                case "Tiger":
                    string tigerBreed=tokens[4];
                    animal =new Tiger(name,weight, argument, tigerBreed);
                    break;
                default:
                    throw new ArgumentException("Invalid animal type!");
            }

            return animal;
        }
    }
}
