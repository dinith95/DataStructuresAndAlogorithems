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
    public void WhenInsertAt_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        linkeList.InsertNode(1,7);
        var node = linkeList.GetNode(1);

        Assert.That(node, Is.Not.Null);
        Assert.That(node.Value, Is.EqualTo(7));
        Assert.That(linkeList.PrintList(), Is.EqualTo("5,7,10,15,"));

        linkeList.InsertNode(4, 20);

        var node2 = linkeList.GetNode(4);
        Assert.That(node2, Is.Not.Null);
        Assert.That(node2.Value, Is.EqualTo(20));
        Assert.That(linkeList.PrintList(), Is.EqualTo("5,7,10,15,20,"));
    }

    [Test]
    public void WhenSetValue_ShouldReturnAsExpected()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        linkeList.SetValue(1, 20);
        var node = linkeList.GetNode(1);

        Assert.That(node.Value, Is.EqualTo(20));
        Assert.That(linkeList.PrintList(), Is.EqualTo("5,20,15,"));
    }

    [Test]
    public void WhenRemoveNode_ShouldReturnAsExpected()
    {
        var linkedList = new CustomLinkedList(5);
        linkedList.Append(10);
        linkedList.Append(15);

        var node = linkedList.RemoveNode(1);

        Assert.That(node, Is.Not.Null);
        Assert.That(node.Value, Is.EqualTo(10));
        Assert.That(node.Next, Is.Null);
        Assert.That(linkedList.PrintList(), Is.EqualTo("5,15,"));

        var node2 = linkedList.RemoveNode(1);

        Assert.That(node2, Is.Not.Null);
        Assert.That(node2.Value, Is.EqualTo(15));
        Assert.That(node2.Next, Is.Null);
        Assert.That(linkedList.PrintList(), Is.EqualTo("5,"));
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

    [Test]
    public void WhenGet_ShoulReturnExpectedNode()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);

        var node = linkeList.GetNode(1);
        var node2 = linkeList.GetNode(3);

        Assert.That(node, Is.Not.Null);
        Assert.That(node.Value, Is.EqualTo(10));

        Assert.That(node2, Is.Null);
    }

    [Test]
    public void WhenGetInEdgeCases_ShouldReturnNull()
    {
        var linkeList = new CustomLinkedList(5);

        linkeList.Pop();

        var node = linkeList.GetNode(0);

        Assert.That(node, Is.Null);
    }

    [Test]
    public void WhenReverese_ShouldRevereseList()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);

        var reversedList = linkeList.Reverse();

        Assert.That(reversedList.Head, Is.Not.Null);
        Assert.That(reversedList.Tail, Is.Not.Null);

        Assert.That(reversedList.Head.Value, Is.EqualTo(20));
        Assert.That(reversedList.Tail.Value, Is.EqualTo(5));
        Assert.That(reversedList.PrintList(), Is.EqualTo("20,15,10,5,"));
    }

    [Test]
    public void WhenGetMiddleInOddLengthLinkedList_ShouldReturnMiddleNode()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);
        linkeList.Append(25);

        var middleNode = linkeList.GetMiddleNode();

        Assert.That(middleNode, Is.Not.Null);
        Assert.That(middleNode.Value, Is.EqualTo(15));
    }

    [Test]
    public void WhenGetMiddleInEvenLengthLinkedList_ShouldReturnMiddleNode()
    {
        var linkeList = new CustomLinkedList(5);

        for (int i = 10; i <= 30; i += 5)
        {
            linkeList.Append(i);
        }

        var middleNode = linkeList.GetMiddleNode();

        Assert.That(middleNode, Is.Not.Null);
        Assert.That(middleNode.Value, Is.EqualTo(20));
    }

    [Test]
    public void WhenHasLoopIsCalled_ShouldReturnFalse()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);

        Assert.That(linkeList.HasLoop(), Is.False);
    }

    [Test]
    public void WhenHasLoopIsCalled_ShouldReturnTrue()
    {
        var linkeList = new CustomLinkedList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);

        linkeList.Tail.Next = linkeList.Head;

        Assert.That(linkeList.HasLoop(), Is.True);
    }
}