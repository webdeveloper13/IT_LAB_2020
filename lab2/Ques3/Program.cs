using System;

namespace Ques3
{
    public delegate void TrafficDel();
    class TrafficSignal
    {
        public void Red()
        {
            Console.WriteLine("RED MEANS STOP!!");
        }

        public void Yellow()
        {
            Console.WriteLine("YELLOW MEANS WAIT!!");
        }

        public void Green()
        {
            Console.WriteLine("GREEN MEANS GO!!");
        }
        static void Main(string[] args)
        {
            TrafficSignal ts = new TrafficSignal();
            TrafficDel td;
            td = ts.Red;
            td();
            td = ts.Yellow;
            td();
            td = ts.Green;
            td();
            //Console.WriteLine("Hello World!");
        }
    }
}
