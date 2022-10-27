using _01._BoxOfT;
using System;
using Xunit;

namespace BoxOfT_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddMethod()
        {
            // Arrange
            IMyBox<string> box = new MyBox<string>();

            // Act
            box.Add("Fisrst");
            box.Add("Second");
            int count = box.Count;

            //Assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void TestRemoveMethod()
        {
            // Arrange
            IMyBox<string> box = new MyBox<string>();

            // Act
            box.Add("Fisrst");
            box.Add("Second");
            string element = box.Remove();
            int count = box.Count;
            //Assert
            Assert.Equal("Second", element);
            Assert.Equal(1, count);
        }

        [Fact]
        public void TestRemoveMethodAtEmptyBox()
        {
            // Arrange
            IMyBox<string> box = new MyBox<string>();

            // Act
            box.Add("Fisrst");
            box.Remove();

            //Assert        
            Assert.Throws<ArgumentOutOfRangeException>(() => box.Remove());
        }
    }
}
