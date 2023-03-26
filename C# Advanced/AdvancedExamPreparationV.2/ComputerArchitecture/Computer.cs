using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor  { get; set; }

        public int Count { get =>Multiprocessor.Count; }
        public void Add(CPU cpu)
        {
            if (Capacity>Count)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            if (Multiprocessor.Any(c=>c.Brand==brand))
            {
              var toRemove = Multiprocessor.Find(c => c.Brand == brand);
                Multiprocessor.Remove(toRemove);
                return true;
            }
            return false;
        }
        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(c=>c.Frequency).First();
        }
        public CPU GetCPU(string brand)
        {
            if (Multiprocessor.Any(c=>c.Brand==brand))
            {
             CPU cpu = Multiprocessor.FirstOrDefault(c=>c.Brand==brand);
                return cpu;
            }
            return null;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
