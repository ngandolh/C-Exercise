using System;
using System.Runtime.CompilerServices;

public class SinglyLinkedList
{
    private Node head;
    public SinglyLinkedList()
    {
        head = null;
    }

    public void InsertedAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        head = newNode;
    }

    public void RemoveAt(int index)
    {
        Node temp = head;
        Node pre = null;
        if (head == null) return;
        //Case: Remove first node
        if (temp != null && temp.Data == index)
        {
            head = temp.Next;
            return;
        }

        //Find need node and save node
        while (temp != null)
        {
            pre = temp;
            temp = temp.Next;
        }

        if (temp == null) return;

        pre.Next = temp.Next;
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
