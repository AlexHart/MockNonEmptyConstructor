using System;
using Xunit;
using Moq;

namespace MockNonEmptyConstructor
{
    public class NoEmptyConstructorTests
    {
        [Fact]
        public void Mock_Class_WithoutEmptyConstructor()
        {
            // Arrange.
            var mock = new Mock<ClassWithoutEmptyConstructor>(MockBehavior.Default, 0);
            mock.Setup(x => x.Value).Returns(123);

            // Act.
            int res = mock.Object.Value;

            // Assert.
            Assert.Equal(123, res);
        }

        [Fact]
        public void Mock_Interface()
        {
            // Arrange.
            var mock = new Mock<IValue>();
            mock.Setup(x => x.Value).Returns(123);

            // Act.
            int res = mock.Object.Value;

            // Assert.
            Assert.Equal(123, res);
        }
    }
}
