using System;

public class LinkedListDemo
{
	//Linked List is a linear data structure which consists of a group of nodes in a sequence
	//Each node contains 2 parts: 
	//Data - Each node of a linked list can store a data.
	//Address - Each node of a linked list contains an address to the next node.

	//Type of Linked List
	//1. Singly Linked List
	//2. Doubly Linked List
	//3. Circular Linked List
	//4. Doubly Circular Linked List


	//Singly linked list contain nodes which have a data part and an address part
	//Which points to the next node in the sequence of nodes.
	//The next pointer of the last node will point to null.
	//public class Program
	//{
 //       public static void Main(string[] args)
 //       {
 //           SinglyLinkedList list = new SinglyLinkedList();

 //           list.InsertedAtBeginning(1);
 //           list.InsertedAtBeginning(2);
 //           list.InsertedAtBeginning(3);

 //           Console.WriteLine("Danh sách sau khi chèn các nút vào đầu:");
 //           list.PrintList(); // Kết quả mong đợi: 3 2 1

 //           list.InsertAtEnd(4);
 //           list.InsertAtEnd(5);

 //           Console.WriteLine("Danh sách sau khi chèn các nút vào cuối:");
 //           list.PrintList(); // Kết quả mong đợi: 3 2 1 4 5

 //           list.RemoveAt(3);
 //           Console.WriteLine("Danh sách sau khi xóa nút có giá trị 3:");
 //           list.PrintList(); // Kết quả mong đợi: 2 1 4 5
 //       }
 //   }
}
