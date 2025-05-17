using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTests.LinkedListTests;

internal class ExtendedLinkedListTests
{
    [Test]
    public void WhenGetMiddleInOddLengthLinkedList_ShouldReturnMiddleNode()
    {
        var linkeList = new ExtendedLinkList(5);
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
        var linkeList = new ExtendedLinkList(5);

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
        var linkeList = new ExtendedLinkList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);

        Assert.That(linkeList.HasLoop(), Is.False);
    }

    [Test]
    public void WhenHasLoopIsCalled_ShouldReturnTrue()
    {
        var linkeList = new ExtendedLinkList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(20);

        linkeList.Tail.Next = linkeList.Head;

        Assert.That(linkeList.HasLoop(), Is.True);
    }

    [Test]
    public void WhenRemoveDuplicates_ShouldReturnExpectedList()
    {
        var linkeList = new ExtendedLinkList(5);
        linkeList.Append(10);
        linkeList.Append(15);
        linkeList.Append(10); // duplicate
        linkeList.Append(20);
        linkeList.Append(15); // duplicate
        linkeList.Append(25);

        linkeList.RemoveDuplicates();

        Assert.That(linkeList.PrintList(), Is.EqualTo("5,10,15,20,25,"));
    }
}
