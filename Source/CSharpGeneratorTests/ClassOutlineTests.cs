using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoDomain.Interfaces;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGeneratorTests
{
    [TestClass]
    public class ClassOutlineTests
    {
        [TestMethod]
        public void GetNamespace_Begin()
        {
            // Arrange
            var iDBInfo = A.Fake<IDBInfo>();
            var iTable = A.Fake<ITable>();
            var sut = new ClassOutline(iDBInfo, iTable);

            // Act
            var result = sut.GetClassOutline();
            // Assert
            result.ShouldBe("");
        }
    }
}