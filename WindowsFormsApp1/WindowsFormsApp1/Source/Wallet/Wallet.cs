using System;

namespace WindowsFormsApp1.Source.Wallet
{
    class Wallet
    {
        public Guid id { get; }
        public string Name { get; }
        

        Wallet(Guid id, string name)
        {
            this.Name = name;
            this.id = id;
        }
    }
}
