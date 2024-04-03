// LinkedList.cs
using System;

public class LinkedList
{
    private Node head;
    public Node Head
    {
        get { return head; }
        set { head = value; }
    }

    private int count;
    public int Count
    {
        get { return count; }
        set { count = value; }
    }

    public void InsertAt(int index, object o)
    {
        if (index < 0 || index > count)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }

        if (index == 0)
        {
            Node newNode = new Node(o);
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            Node newNode = new Node(o);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        count++;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }

        if (index == 0)
        {
            head = head.Next;
        }
        else
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;
        }

        count--;
    }

    public object ItemAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }

        Node current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        return current.Data;
    }

    public override string ToString()
    {
        if (count == 0)
        {
            return string.Empty;
        }

        string result = string.Empty;
        Node current = head;
        while (current != null)
        {
            result += current.ToString();
            if (current.Next != null)
            {
                result += "\n";
            }
            current = current.Next;
        }

        return result;
    }
}

