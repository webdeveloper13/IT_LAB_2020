using System;

namespace Ques2
{
    class Item
    {
        string name;
        static double price = -1.0;
        public string Name
        {
            get;
            set;
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0)
                {
                    price = value;
                }

                else
                {
                    Console.WriteLine("Please Enter positive price value only\n");
                }
            }
        }

        public double CalcGST()
        {
            return 0.08 * price;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double cost = 0.0;
            Item i = new Item();
            Console.WriteLine("Enter the name of the item and its base price\n");
            string name = Console.ReadLine();
            double.TryParse(Console.ReadLine(), out cost);
            i.Price = cost;
            if(i.Price!=-1.0)
            {
                double ans = i.CalcGST();
                Console.WriteLine("The GST charged on {0} will be {1}\n", name, ans);
            }

        }
    }
}
