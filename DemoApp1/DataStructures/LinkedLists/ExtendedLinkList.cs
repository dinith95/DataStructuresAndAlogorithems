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

    public void Partition(int x)
    {
        if (Head == null)
            return;

        // create 2 dummy nodes 
        // tn1 for less than x
        var tn1 = new Node(0);
        var prev1 = tn1;

        // tn2 for greater than or equal to x
        var tn2 = new Node(0);
        var prev2 = tn2;

        var current = Head;

        while (current != null)
        {
            if (current.Value < x)
            {
                prev1.Next = new Node(current.Value);
                prev1 = prev1.Next;
            }
            else
            {
                prev2.Next = new Node(current.Value);
                prev2 = prev2.Next;
            }
            current = current.Next;
        }

        prev1.Next = tn2.Next;

        Head = tn1.Next;
        Tail = prev2;
        tn1 = null;
        tn2 = null;
    }
}