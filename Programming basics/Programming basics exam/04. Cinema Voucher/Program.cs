using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
    {
            int vaucherValue = int.Parse(Console.ReadLine());
            string typeOfProduct = Console.ReadLine();
            int price = 0;
            int tickets = 0;
            int product = 0;
            while (typeOfProduct!="End")
            {
                if (typeOfProduct.Length>=8)
                {
                    price = typeOfProduct[0] + typeOfProduct[1];
                    if (price <= vaucherValue)
                    {


                        
                        vaucherValue -= price;
                        tickets++;
                    }
                    else
                    {
                        
                        break;
                    } 
                }
                else 
                {
                    price = typeOfProduct[0];
                    if (price <= vaucherValue)
                    {
                        vaucherValue -= price;
                        product++;
                    }
                    else
                    {
                       
                        break;
                    }
                }
                
                typeOfProduct = Console.ReadLine();


            }
            Console.WriteLine($"{tickets}");
            Console.WriteLine($"{product}");

        }
    }
}
