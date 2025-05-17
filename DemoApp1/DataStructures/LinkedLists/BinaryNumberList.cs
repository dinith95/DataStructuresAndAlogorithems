namespace DataStructures.LinkedLists;

public class BinaryNumberList : CustomLinkedList
{
    public BinaryNumberList(int value) : base(value)
    {
        if (value != 0 && value != 1)
        {
            throw new ArgumentException("Binary number must be either 0 or 1");
        }
    }


    public void AddBinaryNumber(int number)
    {
        if (number != 0 && number != 1)
        {
            throw new ArgumentException("Binary number must be either 0 or 1");
        }
        Append(number);
    }

    public int ConvertToDecimal()
    {
        var current = Head;
        int decimalValue = 0;

        while (current != null)
        {
            decimalValue = current.Value + decimalValue * 2;
            current = current.Next;
        }

        return decimalValue;
    }
}
