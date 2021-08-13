namespace Lab.Framework.Tests
{
    using AutoMapper;
    using Mapper.Profiles;
    using Xunit;

    public class DiscountProfileShould
    {
        [Fact]
        public void Transform_Discount_To_DiscountDto_When_Correct_Input_Is_Provided()
        {
            // Arrange, Act
            var mapperConfiguration = new MapperConfiguration(configure =>
            {
                configure.AddProfile<DiscountProfile>();
            });

            // Assert
            mapperConfiguration.AssertConfigurationIsValid();
        }
    }
}