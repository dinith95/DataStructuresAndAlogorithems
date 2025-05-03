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

    public CustomLinkedList(int value)
    {
        Head = new Node(value);
        Tail = Head;
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

    public Node Pop()
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
