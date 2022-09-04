using System;
using System.Collections.Generic;
using System.Linq;
namespace Y06._Store_Boxes
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Box>boxes = new List<Box>();
           string command=Console.ReadLine();
            while (command!="end")
            {
                string[] tokens = command.Split();

                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    Item = new Item
                    {
                        Name = tokens[1],
                        Price = decimal.Parse(tokens[3])
                    },
                    ItemQuantity=int.Parse(tokens[2])
                };

                boxes.Add(box);
          
                command = Console.ReadLine();
            }
            List<Box> orderedBoxes = boxes;
            orderedBoxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();
            foreach (Box box1 in orderedBoxes)
            {
                Console.WriteLine(box1.SerialNumber);
                Console.WriteLine($"-- {box1.Item.Name} - ${box1.Item.Price:f2}: {box1.ItemQuantity}");
                Console.WriteLine($"-- ${box1.PriceForABox:f2}");

            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item=new Item();
        }
       public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox 
        { 
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }

    }
}
