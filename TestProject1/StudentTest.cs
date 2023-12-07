using NunitLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
   public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "bhargavi";
            // Act
            string studentName = student.Name;
            // Assert
            Assert.AreEqual("bhargavi", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "123 Main St";
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("123 Main St", studentAddress);
        }
    }
}
