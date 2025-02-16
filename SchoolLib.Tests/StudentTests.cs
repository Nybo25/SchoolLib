using Xunit;
using SchoolLib;
using System;

namespace SchoolLib.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_ValidData_ShouldCreateStudent()
        {
            // Arrange & Act
            var student = new Student(1, "Alice", 3);

            // Assert
            Assert.Equal(1, student.Id);
            Assert.Equal("Alice", student.Name);
            Assert.Equal(3, student.Semester);
        }

        [Theory]
        [InlineData("")]
        public void Student_InvalidName_ShouldThrowArgumentException(string invalidName)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Student(1, invalidName, 3));
            Assert.Contains("Name", exception.Message);
        }

        [Fact]
        public void Student_NullName_ShouldThrowArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new Student(1, null, 3));
            Assert.Contains("Name is null", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(6)]
        public void Student_InvalidSemester_ShouldThrowException(int invalidSemester)
        {
            // Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Student(1, "Bob", invalidSemester));
            Assert.Contains("Semester must be between 1 and 5", exception.Message);
        }

        [Fact]
        public void Student_DefaultConstructor_ShouldSetDefaultValues()
        {
            // Arrange & Act
            var student = new Student();

            // Assert
            Assert.Equal(-1, student.Id);
            Assert.Equal("Unknown", student.Name);
            Assert.Equal(1, student.Semester);
        }
    }
}