﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class SolveTests
    {
        Solve solve = new Solve();
        [TestMethod()]
        public void GetResultTest()
        {
            string TestResult = solve.GetResult();
            Assert.IsNotNull(TestResult);
        }
    }
}