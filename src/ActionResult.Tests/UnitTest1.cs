using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using System.Linq;
using System.Collections;

namespace ActionResult.Tests {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            ActionResult<string> a = "Hello";
            Assert.Equal("Hello", "Hello");
        }

        [Fact]
        public void Test2() {
            List<string> list = new List<string> { "A" };
            ActionResult<List<string>> result = list;
            Assert.Equal(1, result.Value.Count);
        }

        [Fact]
        public void Test3() {
            ActionResult<IEnumerable<string>> list = new[] { "1", "2" };
            Assert.Equal(2, list.Value.Count());
        }
    }
}
