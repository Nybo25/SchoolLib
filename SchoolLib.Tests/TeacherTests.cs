using Xunit;
using SchoolLib;
using System;

namespace SchoolLib.Tests
{
    public class TeacherTests
    {
        [Fact]
        public void Teacher_ValidData_ShouldCreateTeacher()
        {
            var teacher = new Teacher { Id = 1, Name = "John Doe", Salary = 5000 };
            Assert.Equal("John Doe", teacher.Name);
            Assert.Equal(5000, teacher.Salary);
        }

        [Theory]
        [InlineData("")]
        public void Teacher_EmptyName_ShouldThrowArgumentException(string invalidName)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Teacher { Name = invalidName });
            Assert.Equal("Name must be at least 1 character long", exception.Message);
        }

        [Fact]
        public void Teacher_NullName_ShouldThrowArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new Teacher { Name = null });

            Assert.Contains("Name is null", exception.Message);
        }
        
        [Fact]
        public void Teacher_NegativeSalary_ShouldThrowOutOfRangeException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher { Salary = -1000 });
            Assert.Contains("Salary must be >= 0", exception.Message);
        }
    }
}