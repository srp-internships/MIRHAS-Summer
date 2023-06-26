using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Ninja_Test.Fundamentals
{
    [TestFixture]
    class Stack_Test
    {
        Stack<string> stack;
        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }

        [Test]
        public void PushTest_ThrowArgumentNullExceptionIfArgumentIsNull()
        {
            string s = null;
            Assert.That(() => stack.Push(s), Throws.ArgumentNullException);
        }
        [Test]
        public void PopTest_ThrowInvalidOperationsExceptionIfListsCountIsZero()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void PeekTest_ThrowInvalidOperationExceptionIfListsCountIsZero()
        {
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void PushTest_AddValueAndSeeIfTheListChanged()
        {
            stack.Push("1");

            Assert.IsTrue(stack.Count == 1);
        }
        [Test]
        public void PopTest_RemoveAItemAndSeeIfItRealyRemovesIt()
        {
            stack.Push("1");
            stack.Pop();
            Assert.IsTrue(stack.Count == 0);
        }
        [Test]
        public void PeekTest_ShouldReturnTheLastValueOfTheStack()
        {
            stack.Push("1");
            var result = stack.Peek();

            Assert.IsTrue(result == "1");
        }
    }
}
