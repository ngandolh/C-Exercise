using System;
using System.Security.Cryptography.X509Certificates;

public class Node
{
	public int Data {  get; set; }
	public Node Next { get; set; }

	public Node(int data)
	{	
		Data = data;
		Next = null;
	}
}
