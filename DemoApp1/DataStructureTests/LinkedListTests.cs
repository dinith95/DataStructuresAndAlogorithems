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
}