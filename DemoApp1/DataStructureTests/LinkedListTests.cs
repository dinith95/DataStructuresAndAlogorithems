using DataStructures;

namespace DataStructureTests;

public class LinkedListTests

{

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
    public void WhenPrepend_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Prepend(1);

        Assert.That(linkeList.Head, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.SameAs(linkeList.Head));
        Assert.That(linkeList.Head.Value, Is.EqualTo(1));
        Assert.That(linkeList.Tail.Value, Is.EqualTo(10));
        Assert.That(linkeList.PrintList(), Is.EqualTo("1,5,10,"));
    }

    [Test]
    public void WhenPopFirst_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        var firstNode = linkeList.PopFirst();

        Assert.That(linkeList.Head, Is.Not.Null);
        Assert.That(linkeList.Tail, Is.Not.Null);
        Assert.That(firstNode.Value, Is.EqualTo(5));
        Assert.That(linkeList.Head.Value, Is.EqualTo(10));
        Assert.That(linkeList.PrintList(), Is.EqualTo("10,15,"));
    }

    [Test]
    public void WhenPopFirstInEdgeCase_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);

        var node = linkeList.PopFirst();

        Assert.That(linkeList.Head, Is.Null);
        Assert.That(linkeList.Tail, Is.Null);

        Assert.That(node.Value, Is.EqualTo(5));

        var node2 = linkeList.PopFirst();

        Assert.That(linkeList.Head, Is.Null);
        Assert.That(linkeList.Tail, Is.Null);
        Assert.That(node2, Is.Null);
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