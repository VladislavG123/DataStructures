namespace DataStructures.Tests.List;

public partial class ListTests
{
    [Test]
    [TestCase(0)] // BVA
    [TestCase(1)] // Use Case Testing
    [TestCase(2)] // BVA
    [Description("Tests indexator of List in case of usage for taking items. Positive Testing")]
    public void IndexatorGetTests_ShouldGetValue(int index)
    {
        // Arrange
        var list = new IntList(1, 1, 1);

        // Act
        var result = list[index];

        // Assert
        result.Should().Be(1);
    }

    [Test]
    [TestCase(-1)] // BVA
    [TestCase(3)] // BVA
    [Description("Tests indexator of List in case of usage for taking items. Negative Testing.")]
    public void IndexatorGetTests_ShouldThrowException(int index)
    {
        // Arrange
        var list = new IntList(1, 1, 1);

        // Act
        var action = () =>
        {
            var _ = list[index];
        };

        // Assert
        action.Should().Throw<IndexOutOfRangeException>();
    }

    [Test]
    [TestCase(0)] // Use Case Testing
    [Description("Setting value using indexer. Positive test")]
    public void IndexatorSetTests_ShouldChangeValue(int index)
    {
        // Arrange
        var list = new IntList {1};

        // Act
        list[index] = 2;

        // Assert
        list[index].Should().Be(2);
    }

    [Test]
    [TestCase(-1)] // BVA
    [TestCase(1)] // Empty index (when Count <= index <= Capacity)
    [Description("Setting value using indexer. Negative test")]
    public void IndexatorSetTests_ShouldThrowException(int index)
    {
        // Arrange
        var list = new IntList {1};

        // Act
        var action = () => { list[index] = 2; };

        // Assert
        action.Should().Throw<IndexOutOfRangeException>();
    }

    [Test]
    [Description("Checks the behaviour of adding new item")]
    public void AddMethodTest_ShouldAddExactValueToList()
    {
        // Arrange
        var list = new IntList();
        var value = 5;

        // Act
        list.Add(value);

        // Assert
        list[0].Should().Be(value);
    }

    [Test]
    [Description("Checks the behaviour of adding multiple new items one by one. Testing how capacity increases")]
    public void AddMethodTest_ShouldAddNewItemsAndIncreaseCapacity()
    {
        // Arrange
        var list = new IntList();

        // Act
        for (int i = 0; i < 100; i++)
        {
            list.Add(1);
        }

        // Assert
        list.Should()
            .HaveCount(100)
            .And
            .OnlyHaveUniqueItems(x => x == 1);
    }

    [Test]
    [TestCase(0)] // BVA
    [TestCase(1)] // Use Case Testing
    [TestCase(2)] // BVA
    [Description("ElementAt behaviour test. Positive Testing")]
    public void ElementAtTests_ShouldGetValue(int index)
    {
        // Arrange
        var list = new IntList(1, 1, 1);

        // Act
        var result = list.ElementAt(index);

        // Assert
        result.Should().Be(1);
    }

    [Test]
    [TestCase(-1)] // BVA
    [TestCase(3)] // BVA
    [Description("ElementAt behaviour test. Negative Testing.")]
    public void ElementAtTests_ShouldThrowException(int index)
    {
        // Arrange
        var list = new IntList(1, 1, 1);

        // Act
        var action = () =>
        {
            var _ = list.ElementAt(index);
        };

        // Assert
        action.Should().Throw<IndexOutOfRangeException>();
    }

    [Test]
    [TestCase(0)] // Use Case Testing
    [Description("SetValue method behaviour tests. Positive test")]
    public void SetValueTests_ShouldChangeValue(int index)
    {
        // Arrange
        var list = new IntList {1};

        // Act
        list.SetValue(index, 2);

        // Assert
        list[index].Should().Be(2);
    }

    [Test]
    [TestCase(-1)] // BVA
    [TestCase(1)] // Empty index (when Count <= index <= Capacity)
    [Description("SetValue method behaviour tests. Negative test")]
    public void SetValueTests_ShouldThrowException(int index)
    {
        // Arrange
        var list = new IntList {1};

        // Act
        var action = () => { list.SetValue(index, 2); };

        // Assert
        action.Should().Throw<IndexOutOfRangeException>();
    }

    [Test]
    [Description("Checks if ToArray() works")]
    public void ToArrayTests_ShouldReturnArray()
    {
        // Arrange
        var list = new IntList {0, 1, 2};

        // Act
        var array = list.ToArray();

        // Assert
        array.Should()
            .HaveCount(3)
            .And
            .BeEquivalentTo(new[] {0, 1, 2});
    }

    [Test]
    [Description("Checks if result of ToArray() is the clone and does not affect to List behaviour")]
    public void ToArrayTests_ShouldReturnCopyOfArray()
    {
        // Arrange
        var list = new IntList {1, 2, 3};
        var array = list.ToArray();

        // Act
        array[0] = 5;

        // Assert
        list[0].Should().Be(1);
    }
}