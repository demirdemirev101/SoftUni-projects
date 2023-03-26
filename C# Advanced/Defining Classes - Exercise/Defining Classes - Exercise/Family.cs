using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
       public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person[] GetOldestMember()
        {
            var result=new List<Person>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Age>30)
                {
                    result.Add(People[i]);
                }
            }
            People.Clear();
            return result.OrderBy(p=>p.Name).ToArray();
        }
    }
}
