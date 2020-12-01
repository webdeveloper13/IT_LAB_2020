using System;

namespace Ques1
{
    class Item
    {
        private string name;
        private int price;
        public delegate void PriceChangeHandler();
        public event PriceChangeHandler PriceChanged;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                if(PriceChanged!=null)
                {
                    PriceChanged();
                }
            }
        }

        public void ChangeHappened()
        {
            Console.WriteLine("Event Handler is Invoked now\nNow The price for {0} is {1}", name, price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item();
            int cost;
            i.PriceChanged += i.ChangeHappened;
            Console.WriteLine("Enter the name of the item and its price");
            i.Name = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out cost);
            i.Price = cost;
        }
    }
}
