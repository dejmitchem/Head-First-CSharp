using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LumberjackFlapjackApp
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }

        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

        public Lumberjack(string name)
        {
            this.name = name;
        }

        public void TakeFlapjacks(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public bool EatFlapjacks()
        {
            if (flapjackStack.Count == 0) return false;

            Console.WriteLine($"{Name} ate a {flapjackStack.Pop()} flapjack");
            return true;
        }
    }
}
