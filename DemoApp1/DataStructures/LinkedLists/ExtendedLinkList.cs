namespace DataStructures.LinkedLists;

public class ExtendedLinkList : CustomLinkedList
{
    public ExtendedLinkList(int value) : base(value)
    {
    }

    public bool HasLoop()
    {
        if (Head == null)
            return false;

        var slow = Head;
        var fast = Head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next?.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    public bool HasLoopWithHashSet()
    {
        if (Head == null)
            return false;

        var current = Head;

        var visitedNodes = new HashSet<int>();

        while (current != null)
        {
            var nodeHash = current.GetHashCode();
            if (visitedNodes.Contains(nodeHash))
            {
                return true;
            }
            visitedNodes.Add(nodeHash);
            current = current.Next;
        }

        return false;
    }

    public Node? GetMiddleNode()
    {
        if (Head == null) return null;

        var slow = Head;
        var fast = Head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next?.Next;
        }

        return slow;
    }

    public void RemoveDuplicates()
    {
        if (Head == null)
        {
            return;
        }
        var current = Head;
        var prev = Head;

        var values = new HashSet<int>();

        while (current != null)
        {
            if (values.Contains(current.Value))
            {
                prev.Next = current.Next;
                var temp = current;
                current = current.Next;
                temp.Next = null;
            }
            else
            {
                values.Add(current.Value);
                prev = current;
                current = current.Next;
            }

        }
    }
}