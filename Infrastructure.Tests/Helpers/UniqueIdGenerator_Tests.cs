using Infrastructure.Helpers;

namespace Infrastructure.Tests.Helpers;

public interface UniqueIdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldreturnGuidAsString_WhenSuccessful()
    {
        // Act
        var result = UniqueIdGenerator.Generate();

        // Assert
        Assert.NotEmpty(result);
        Assert.True(Guid.TryParse(result, out _));
    }
        
}
