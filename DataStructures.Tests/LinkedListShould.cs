using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructures.Tests
{
    [TestClass]
    public class LinkedListShould
    {
        [TestMethod]
        public void Have_Ability_To_Add_To_Head_Or_Tail_Node()
        {
            LinkedList<int> list = new LinkedList<int>();
            Node<int> headNode = new Node<int>(100);
            Node<int> tailNode = new Node<int>(200);
            list.AddToHead(headNode);
            list.AddToTail(tailNode);
            Assert.AreSame(headNode, list.Head);
            Assert.AreSame(tailNode, list.Tail);
        }

        [TestMethod]
        public void Have_Ability_To_Remove_Head_Or_Tail_Node()
        {
            LinkedList<int> list = new LinkedList<int>();
            Node<int> node100 = new Node<int>(100);
            Node<int> node200 = new Node<int>(200);
            Node<int> node300 = new Node<int>(300);
            list.AddToTail(node100);
            list.AddToTail(node200);
            list.AddToTail(node300);
            Assert.AreSame(node100, list.Head);
            list.RemoveFromHead();
            Assert.AreSame(node200, list.Head);
            Assert.AreSame(node300, list.Tail);
            list.RemoveFromTail();
            Assert.AreSame(node200, list.Tail);
        }

        [TestMethod]
        public void Have_Count_Of_Current_Items()
        {
            LinkedList<int> list = new LinkedList<int>();
            Node<int> node100 = new Node<int>(100);
            Node<int> node200 = new Node<int>(200);
            Node<int> node300 = new Node<int>(300);
            Assert.AreEqual(0, list.Count);
            list.AddToTail(node100);
            Assert.AreEqual(1, list.Count);
            list.AddToTail(node200);
            Assert.AreEqual(2, list.Count);
            list.AddToTail(node300);
            Assert.AreEqual(3, list.Count);
        }

    }
}
