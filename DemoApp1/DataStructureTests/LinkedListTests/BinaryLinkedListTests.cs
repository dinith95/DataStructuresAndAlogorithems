using DataStructures;
using DataStructures.LinkedLists;

namespace DataStructureTests.LinkedListTests;

public class BinaryLinkedListTests
{
    [Test]
    public void WhenCalledConstructor_ShouldReturnAsExpected()
    {
        var binaryLinkedList = new BinaryNumberList(1);

        Assert.That(binaryLinkedList.Head, Is.Not.Null);
        Assert.That(binaryLinkedList.Head.Value, Is.EqualTo(1));
    }

    [Test]
    public void WhenInsert_ShouldReturnAsExpected()
    {
        var binaryLinkedList = new BinaryNumberList(1);
        binaryLinkedList.AddBinaryNumber(0);
        binaryLinkedList.AddBinaryNumber(1);

        Assert.That(binaryLinkedList.ConvertToDecimal(), Is.EqualTo(5));

        binaryLinkedList.AddBinaryNumber(1);
        Assert.That(binaryLinkedList.ConvertToDecimal(), Is.EqualTo(11));
    }
}
