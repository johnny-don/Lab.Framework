namespace Lab.Framework.Repositories
{
    using System.Collections.Immutable;
    using Entities;

    public interface IDiscountRepository
    {
        public IImmutableList<Discount> Get();
    }
}