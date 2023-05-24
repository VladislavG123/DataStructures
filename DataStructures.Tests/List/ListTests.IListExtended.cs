namespace DataStructures.Tests.List;

public partial class ListTests
{
    [Test]
    [Description("Tests if AddRange adds elements to the end")]
    public void AddRangeParamsTest_ShouldAddItems()
    {
        // Arrange
        var list = new IntList{1, 2, 3};

        // Act
        list.AddRange(4, 5, 6);
        
        // Assert
        list.Should().Equal(1, 2, 3, 4, 5, 6);
    }
    
    
}