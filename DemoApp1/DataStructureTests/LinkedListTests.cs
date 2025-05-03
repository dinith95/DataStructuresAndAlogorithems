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

    [Test]
    public void WhenPop_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        var lastNode = linkeList.Pop();

        Assert.That(linkeList.Head, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.Null);
        Assert.That(lastNode.Value, Is.EqualTo(15));    
        Assert.That(linkeList.Head.Value, Is.EqualTo(5));
        Assert.That(linkeList.Tail.Value, Is.EqualTo(10));
        Assert.That(linkeList.PrintList(), Is.EqualTo("5,10,"));
    }

    [Test]
    public void WhenPop_ShouldReturnNull()
    {
        var linkeList = new CustomLinkedList(5);

        var lastNode = linkeList.Pop();

        Assert.That(linkeList.Head, Is.Null);
        Assert.That(linkeList.Tail, Is.Null);
        Assert.That(lastNode.Value, Is.EqualTo(5));

        var lastNode2 = linkeList.Pop();

        Assert.That(linkeList.Head, Is.Null);
        Assert.That(linkeList.Tail, Is.Null);
        Assert.That(lastNode2, Is.Null);

    }
}