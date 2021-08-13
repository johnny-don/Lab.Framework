namespace Lab.Framework.Dto
{
    using System;

    public class DiscountDto
    {
        public Guid Id { get;set; }

        public string Name { get;set; }

        public int Amount { get;set; }

        public char Grade =>
            Amount switch
            {
                var amount when amount >= 0 & amount < 30 => 'C',
                var amount when amount >= 30 & amount < 60 => 'B',
                _ => 'A'
            };

        public DiscountDto(Guid id, string name, int amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
    }
}
