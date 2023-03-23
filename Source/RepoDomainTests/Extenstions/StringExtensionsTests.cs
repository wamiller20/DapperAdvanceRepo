using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoDomain.Extenstions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace RepoDomain.Extenstions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        [DataRow("I","i")]
        [DataRow("IPay", "iPay")]
        [DataRow("", "")]
        [DataRow("iPay", "iPay")]
        public void FirstCharToLowerCaseTest(string input, string resultShouldBe)
        {
            input.FirstCharToLowerCase().ShouldBe(resultShouldBe);
        }
    }
}