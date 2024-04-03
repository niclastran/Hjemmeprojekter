// Node.cs
using System;

public class Node
{
    private object data;
    public object Data
    {
        get { return data; }
        set { data = value; }
    }

    private Node next;
    public Node Next
    {
        get { return next; }
        set { next = value; }
    }

    public Node(object data)
    {
        this.data = data;
        this.next = null;
    }

    public override string ToString()
    {
        return data.ToString();
    }
}
