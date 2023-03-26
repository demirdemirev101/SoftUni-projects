using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphonable
    {

        public void Calling(string phoneNumber)
        {
            
                foreach (var c in phoneNumber)
                {
                    if (char.IsLetter(c))
                    {
                        Console.WriteLine("Invalid number!");
                        return;
                    }
                }
            
                Console.WriteLine($"Calling... {phoneNumber}");
        }
        public void Browsing(string website)
        {
            foreach (var site in website)
            {
                    if (char.IsDigit(site))
                    {
                        Console.WriteLine("Invalid URL!");
                        return;
                    }
            }
                Console.WriteLine($"Browsing: {website}!");
        }
    }
}
