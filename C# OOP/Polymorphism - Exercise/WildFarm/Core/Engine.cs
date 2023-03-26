namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using IO.Interfaces;
    using WildFarm.Factories.Interfaces;
    using WildFarm.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        private readonly ICollection<IAnimal> animals;
        private Engine()
        {
            animals=new HashSet<IAnimal>();
        }
        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
            :this()
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            string command;
            while ((command = reader.ReadLine())!="End")
            {
                HandleInput(command);
            }

            PrintAllAnimals();
        }

        private void HandleInput(string command)
        {
            IAnimal currAnimal=null;
            try
            {
                 currAnimal = BuildAnimalUsingAnimalFactory(command);
                IFood currFood = BuildFoodUsingFoodFactory();

                this.writer.WriteLine(currAnimal.ProducingSound());

                currAnimal.EatFood(currFood);
            }
            catch (ArgumentException ar)
            {

                writer.WriteLine(ar.Message);
            }
            catch (Exception)
            {
                throw;
            }
                this.animals.Add(currAnimal);
            
        }

        private IAnimal BuildAnimalUsingAnimalFactory(string command)
        {
            string[] animalTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IAnimal currAnimal = animalFactory.CreateAnimal(animalTokens);
            return currAnimal;
        }
        private IFood BuildFoodUsingFoodFactory()
        {
            string[] foodTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = foodTokens[0];
            int quantity = int.Parse(foodTokens[1]);
            IFood currFood = foodFactory.CreateFood(type, quantity);
            return currFood;
        }
        private void PrintAllAnimals()
        {
            foreach (IAnimal animal in animals)
            {
                this.writer.WriteLine(animal.ToString());
            }
        }
    }
}
