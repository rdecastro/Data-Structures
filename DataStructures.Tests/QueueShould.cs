using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class QueueShould
    {
        [TestMethod]
        public void Add_To_End_Of_List_And_Remove_From_Beginning_Of_List()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            Assert.AreEqual(100, queue.Dequeue());
            Assert.AreEqual(200, queue.Dequeue());
            Assert.AreEqual(300, queue.Dequeue());
        }

        [TestMethod]
        public void Have_A_Count_Of_Current_Items()
        {
            Queue<string> queue = new Queue<string>();
            Assert.AreEqual(0, queue.Count);
            queue.Enqueue("ABC");
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue("DEF");
            Assert.AreEqual(2, queue.Count);
            queue.Enqueue("GHI");
            Assert.AreEqual(3, queue.Count);
            Assert.AreEqual("ABC", queue.Dequeue());
            Assert.AreEqual(2, queue.Count);
            Assert.AreEqual("DEF", queue.Dequeue());
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual("GHI", queue.Dequeue());
            Assert.AreEqual(0, queue.Count);
        }
    }
}
