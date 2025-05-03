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
