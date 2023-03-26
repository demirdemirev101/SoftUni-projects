using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhonable
    {
        public void Dialing(string phoneNumber)
        {
            
                foreach (var c in phoneNumber)
                {
                    if (char.IsLetter(c))
                    {
                        Console.WriteLine("Invalid number!");
                        return;
                    }
                }
            
                Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
