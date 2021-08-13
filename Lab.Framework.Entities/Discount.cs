namespace Lab.Framework.Entities
{
    using System;

    public class Discount
    {
        public Guid Id { get; }

        public string Name { get; }

        public int Amount { get; }

        public bool HasExpired { get; }

        public Discount(Guid id, string name, bool hasExpired, int amount)
        {
            Id = id;
            Name = name;
            HasExpired = hasExpired;
            Amount = amount;
        }
    }
}