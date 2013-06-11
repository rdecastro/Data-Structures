using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructures.Tests
{
    [TestClass]
    public class NodeShould
    {
        [TestMethod]
        public void Have_A_Value()
        {
            Node<int> node = new Node<int>();
            node.Value = 100;
            Assert.AreEqual(100, node.Value);
        }

        [TestMethod]
        public void Have_A_Pointer_To_Next_Node()
        {
            Node<int> nodeA = new Node<int>();
            nodeA.Value = 100;

            Node<int> nodeB = new Node<int>();
            nodeB.Value = 200;
            nodeA.Next = nodeB;

            Assert.AreSame(nodeB, nodeA.Next);
        }
    }
}
