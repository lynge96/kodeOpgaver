using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class SortedLinkedList_Tests
    {
        [TestMethod]
        public void TestAdd()
        {
            User kristian = new User("Kristian", 3);
            User mads = new User("Mads", 1);
            User torill = new User("Torill", 2);

            SortedUserLinkedList list = new SortedUserLinkedList();

            list.Add(kristian);
            list.Add(mads);
            list.Add(torill);

            Assert.AreEqual(mads, list.GetFirst());

        }


    }
}