using DataStructures;

namespace DataStructureTests;



public class LinkedListTests

{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WhenCalledConstructor_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);

        Assert.That(linkeList.Head, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.SameAs(linkeList.Head));
        Assert.That(linkeList.Head.Value, Is.EqualTo(5));
    }

    [Test]
    public void WhenAppend_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        Assert.That(linkeList.Head, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.SameAs(linkeList.Head));
        Assert.That(linkeList.Head.Value, Is.EqualTo(5));
        Assert.That(linkeList.Tail.Value, Is.EqualTo(15));
        Assert.That(linkeList.PrintList(), Is.EqualTo("5,10,15,"));
    }
}