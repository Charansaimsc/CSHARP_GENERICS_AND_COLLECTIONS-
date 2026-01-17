/*Find the Nth Element from the End
Given a singly linked list (LinkedList), find the Nth element from the end
without calculating its size.
Example:
Input: [A, B, C, D, E], N=2
Output: D*/
using System;
using System.Collections.Generic;
class Node 
{
    public int data;
    public  Node Next;
    public Node(int data)
    {
        this.data= data;
        Next = null;
    }
}
class LinkedList
{
    public Node Head;
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if(Head == null)
        {
            Head = newNode;
            return;
        }
        Node temp = Head;
        while (temp.Next != null)
        {
            temp = temp.Next;
           
        }
         temp.Next = newNode;
    }
    public int FindNth(int n)
    {
        Node Slow = Head;
        Node Fast = Head ;
        for(int i=0;i<n; i++)
        {
            
            Fast = Fast.Next;
        }
        while(Fast!= null)
        {
            Fast = Fast.Next;
            Slow = Slow.Next;
        }
        return Slow.data;
    }
}