using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Event_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            EvtPublisher ep = new EvtPublisher();

            EvtSubscriber es = new EvtSubscriber();

            ep.evt += es.HandleTheEvent;

            ep.CheckBalance(260);
        }
    }
    public class EvtPublisher
    {
        public delegate void del(string x);

        public event del evt;

        public void CheckBalance (int x)
        {
            if (x > 250)
                evt("The current balance exceed 250");
        }
    }
    public class EvtSubscriber
    {
        public void HandleTheEvent (string a)
        {
            Console.WriteLine(a);
        }
    }
}
