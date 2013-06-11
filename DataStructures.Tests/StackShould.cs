using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class StackShould
    {
        [TestMethod]
        public void Push_Item_From_Top()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            Assert.AreEqual("A", stack.Peek());
            stack.Push("B");
            Assert.AreEqual("B", stack.Peek());
        }

        [TestMethod]
        public void Pop_Item_From_Top()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            Assert.AreEqual("C", stack.Pop());
            Assert.AreEqual("B", stack.Pop());
            Assert.AreEqual("A", stack.Pop());
        }
    }
}
