namespace DataStructures;

public record Node(int Value, Node Next);

public class CustomLinkedList
{
    public Node Head { get; init; }
    
    public Node Tail { get; init; }

    public CustomLinkedList(int value)
    {
        Head = new Node(value, null);
        Tail = Head;
    }
}
