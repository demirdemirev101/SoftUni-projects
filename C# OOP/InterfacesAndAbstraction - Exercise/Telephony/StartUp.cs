using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length==10)
                {
                    ISmartphonable smartphone = new Smartphone();
                    smartphone.Calling(phoneNumber);
                }
                else if (phoneNumber.Length == 7)
                {
                    IStationaryPhonable stationary = new StationaryPhone();
                    stationary.Dialing(phoneNumber);
                }
            }
            
            string[] websites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            foreach(var website in websites)
            {
                ISmartphonable phone = new Smartphone();
                phone.Browsing(website);
            }
        }
    }
}
