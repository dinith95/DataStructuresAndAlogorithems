using System.Text;

namespace DataStructures;

public class Node
{
    public Node(int value, Node next)
    {
        Value = value;
        Next = next;
    }

    public Node(int value)
    {
        Value = value;
    }

    public int Value { get; set; }

    public Node Next { get; set; }
}



public class CustomLinkedList
{
    public Node Head { get; private set; }

    public Node Tail { get; private set; }

    public int Length { get; private set; }
    

    public CustomLinkedList(int value)
    {
        Head = new Node(value);
        Tail = Head;
        Length = 1;
    }

    public void Append(int value)
    {
        if (Head == null)
        {
            Head = new Node(value);
            Tail = Head;
        }
        else
        {
            Tail.Next = new Node(value);
            Tail = Tail.Next;
        }
        Length++;
    }

    public void Prepend(int value)
    {
        if (Head == null)
        {
            Head = new Node(value);
            Tail = Head;
        }
        else
        {
            var newNode = new Node(value, Head);
            Head = newNode;
        }
        Length++;
    }

    public void InsertNode(int index, int value)
    {
        if (index < 0 || Head == null)
        {
            return;
        }

        if (index == 0)
        {
            Prepend(value);
            return;
        }

       var prevNode = GetNode(index-1);

       var newNode = new Node(value, prevNode.Next);

        prevNode.Next = newNode;
        Length++;

    }

    public bool SetValue(int index, int value)
    {
        if (index < 0 || Head == null)
        {
            return false;
        }

        var node = GetNode(index);

        if(node != null)
        {
            node.Value = value;
            return true;
        }
        else
        {
            return false;
        }
    }

    public Node? RemoveNode(int index)
    {
        if (index < 0 || Head == null || index >= Length)
        {
            return null;
        }

        if (index == 0)
        {
            var temp = Head;
            Head = Head.Next;
            return temp;
        }

       var prevNode = GetNode(index - 1);

       var currentNode = prevNode.Next;

        prevNode.Next = currentNode.Next;
        currentNode.Next = null;
        return currentNode;
    }

    public Node? PopFirst()
    {
        if (Head == null)
        {
            return null;
        }

        if (Head == Tail)
        {
            var temp = Head;
            Head = null;
            Tail = null;
            return temp;
        }

        var firstItem = Head;
        Head = Head.Next;
        return firstItem;
    }

    public Node? Pop()
    {
        var current = Head;

        if (Head == null)
        {
            return null;
        }

        if (Head == Tail)
        {
            var temp = Head;
            Head = null;
            Tail = null;
            return temp;
        }

        while (current.Next != Tail)
        {
            current = current.Next;
        }
        var last = current.Next;
        current.Next = null;
        Tail = current;
        return last;
    }

    public Node? GetNode(int index)
    {
        if(index < 0 || Head == null )
        {
            return null;
        }

        var current = Head;
        var count = 0;
        while (current != null)
        {
            if (count == index)
            {
                return current;
            }
            count++;
            current = current.Next;
        }
        return null;
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

    public CustomLinkedList Reverse()
    {
        if (Head == null)
        {
            return null;
        }

        Node? prev = null;
        var current = Head;
        var next = Head.Next;

        while (current != null)
        {
            current.Next = prev;
            prev = current;
            current = next;
            next= next?.Next;

        }

        // swapping head and tail
        var temp = Head;
        Head = Tail;
        Tail = temp;
        return this;

    }

    public Node GetNodeFromEnd(int index)
    {
        if (Head == null || index < 0)
        {
            return null;
        }

        var current = Head;
        var secondary = GetNode(index-1);

        while(secondary.Next != null)
        {
            current = current.Next;
            secondary = secondary.Next;
        }

        return current;
    }

    public string PrintList()
    {
        var current = Head;
        var result = new StringBuilder();
        while (current != null)
        {
            result.Append(current.Value + ",");
            current = current.Next;
        }
        return result.ToString();
    }
}
