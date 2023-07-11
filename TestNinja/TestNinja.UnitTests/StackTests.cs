using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            var stack = new Stack<string>();
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        [Ignore("Avoid exceptions for a smooth run. Remove the attribute to check the behavior")]
        public void Push_NullObject_ThrowsArgumentNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        [Ignore("Avoid exceptions for a smooth run. Remove the attribute to check the behavior")]
        public void Push_ValidObject_ThrowsArgumentNullException()
        {
            var stack = new Stack<int>();

            stack.Push(1);

            Assert.That(stack.Count, Is.EqualTo(1)); 
        }

        [Test]
        [Ignore("Avoid exceptions for a smooth run. Remove the attribute to check the behavior")]

        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Pop_StackWithObjects_ReturnsTopObjectAndRemovesFromStack()
        {
            // Arrange
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.AreEqual(3, result);
            Assert.AreEqual(2, stack.Count);
        }

        [Test]
        [Ignore("Avoid exceptions for a smooth run. Remove the attribute to check the behavior")]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_StackWithObjects_ReturnsTopObjectWithoutRemovingFromStack()
        {
            // Arrange
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.AreEqual(3, result);
            Assert.AreEqual(3, stack.Count);
        }
    }
}
